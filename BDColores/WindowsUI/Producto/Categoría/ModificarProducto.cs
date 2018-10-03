using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace WindowsUI
{
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            label7.Visible = false;
            label8.Visible = false;
            this.dataGridView1.Enabled = false;
            ClassColorBLL nuevo = new ClassColorBLL();
            this.dataGridView1.DataSource = nuevo.MostrarProductos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ScrollBars = ScrollBars.Both;
            this.dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Refresh();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {
            if (label7.Text == "3")
            {
                groupBox1.Enabled = true;
                this.dataGridView1.Enabled = true;
            }
            else if (label7.Text == "4")
            {
                groupBox2.Enabled = true;
                button2.Enabled = false;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView2.DataSource = nuevo.MostrarProductos();
                this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView2.ScrollBars = ScrollBars.Both;
                this.dataGridView2.ForeColor = Color.Black;
                this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView2.Refresh();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            ClassColorBLL nuevo = new ClassColorBLL();
            MODELS.Producto producto = new MODELS.Producto();
            label8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            richTextBox1.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            groupBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassColorBLL nuevo = new ClassColorBLL();
            MODELS.Producto producto = new MODELS.Producto();
            producto.ProductoId = Convert.ToInt32(this.label8.Text);
            producto.nombre_producto = textBox1.Text;
            producto.porcentaje_descuento = Convert.ToInt32(textBox5.Text);
            producto.estado_producto = true;
            producto.descripcion_producto = richTextBox1.Text;
            nuevo.ActualizarProducto(producto);
            MessageBox.Show("Producto modificado con éxito.");
            textBox1.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
            groupBox1.Enabled = false;
            dataGridView1.Visible = true;
            this.dataGridView1.DataSource = nuevo.MostrarProductos();
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ScrollBars = ScrollBars.Both;
            this.dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[3].Value) == 0)
            {
                ClassColorBLL nuevo = new ClassColorBLL();
                MODELS.Producto producto = new MODELS.Producto();
                producto.ProductoId = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
                producto.nombre_producto = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                producto.descripcion_producto = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                producto.estado_producto = false;
                producto.porcentaje_descuento = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[4].Value.ToString());
                nuevo.EliminarProducto(producto);
                MessageBox.Show("Producto eliminado exitosamente.");
                this.dataGridView2.DataSource = nuevo.MostrarProductos();
                this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView2.ScrollBars = ScrollBars.Both;
                this.dataGridView2.ForeColor = Color.Black;
                this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView2.Refresh();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
