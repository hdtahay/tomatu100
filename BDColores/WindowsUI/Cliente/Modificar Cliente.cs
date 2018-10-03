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
    public partial class Modificar_Cliente : Form
    {
        public Modificar_Cliente()
        {
            InitializeComponent();
            label6.Visible = false;
            label7.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            this.dataGridView2.Enabled = false;
            ClassColorBLL nuevo = new ClassColorBLL();
            this.dataGridView2.DataSource = nuevo.MostrarClientes();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ScrollBars = ScrollBars.Both;
            this.dataGridView2.ForeColor = Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.Refresh();
        }

        private void Modificar_Cliente_Load(object sender, EventArgs e)
        {
            if (label6.Text == "3")
            {
                groupBox1.Enabled = true;
                this.dataGridView2.Enabled = true;
            }
            else if (label6.Text == "4")
            {
                groupBox2.Enabled = true;
                button2.Enabled = false;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView1.DataSource = nuevo.MostrarClientes();
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView1.ScrollBars = ScrollBars.Both;
                this.dataGridView1.ForeColor = Color.Black;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value) == 0)
            {
                ClassColorBLL nuevo = new ClassColorBLL();
                MODELS.Cliente cliente = new MODELS.Cliente();
                cliente.ClienteId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cliente.nombre_cliente = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cliente.apellido_cliente = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cliente.estado_cliente = false;
                cliente.nit_cliente = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nuevo.EliminarCliente(cliente);
                MessageBox.Show("Cliente eliminado exitosamente.");
                this.dataGridView1.DataSource = nuevo.MostrarClientes();
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView1.ScrollBars = ScrollBars.Both;
                this.dataGridView1.ForeColor = Color.Black;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true;
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.dataGridView2.Visible = false;
            ClassColorBLL nuevo = new ClassColorBLL();
            MODELS.Cliente cliente = new MODELS.Cliente();
            label7.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            groupBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassColorBLL nuevo = new ClassColorBLL();
            MODELS.Cliente cliente = new MODELS.Cliente();
            cliente.ClienteId = Convert.ToInt32(this.label7.Text);
            cliente.nombre_cliente = textBox1.Text;
            cliente.apellido_cliente = textBox2.Text;
            cliente.estado_cliente = true;
            cliente.nit_cliente = textBox3.Text;
            nuevo.ActualizarCliente(cliente);
            MessageBox.Show("Cliente modificado con éxito.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            groupBox1.Enabled = false;
            dataGridView2.Visible = true;
            this.dataGridView2.DataSource = nuevo.MostrarClientes();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ScrollBars = ScrollBars.Both;
            this.dataGridView2.ForeColor = Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.Refresh();
        }
    }
}
