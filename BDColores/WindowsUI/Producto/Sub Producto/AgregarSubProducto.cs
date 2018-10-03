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
namespace WindowsUI.Producto.Sub_Producto
{
    public partial class AgregarSubProducto : Form
    {
        public AgregarSubProducto()
        {
            InitializeComponent();
        }

        private void AgregarSubProducto_Load(object sender, EventArgs e)
        {
            this.groupBox1.Visible = false;
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox4.Enabled = false;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem.ToString() == "Accesorio")
            {
                this.groupBox1.Visible = true;
                this.groupBox1.Enabled = true;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView1.DataSource = nuevo.MostrarProductos();
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView1.ScrollBars = ScrollBars.Both;
                this.dataGridView1.ForeColor = Color.Black;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.Refresh();

                this.groupBox2.Visible = false;
                this.groupBox2.Enabled = false;
                this.groupBox3.Visible = false;
                this.groupBox3.Enabled = false;
                this.groupBox4.Visible = false;
                this.groupBox4.Enabled = false;

            }
            else if (this.comboBox1.SelectedItem.ToString() == "Solvente")
            {
                this.groupBox2.Visible = true;
                this.groupBox2.Enabled = true;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView2.DataSource = nuevo.MostrarProductos();
                this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView2.ScrollBars = ScrollBars.Both;
                this.dataGridView2.ForeColor = Color.Black;
                this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView2.Refresh();

                this.groupBox1.Visible = false;
                this.groupBox1.Enabled = false;
                this.groupBox3.Visible = false;
                this.groupBox3.Enabled = false;
                this.groupBox4.Visible = false;
                this.groupBox4.Enabled = false;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Pintura")
            {
                this.groupBox3.Visible = true;
                this.groupBox3.Enabled = true;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView3.DataSource = nuevo.MostrarProductos();
                this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView3.ScrollBars = ScrollBars.Both;
                this.dataGridView3.ForeColor = Color.Black;
                this.dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView3.Refresh();

                this.groupBox2.Visible = false;
                this.groupBox2.Enabled = false;
                this.groupBox1.Visible = false;
                this.groupBox1.Enabled = false;
                this.groupBox4.Visible = false;
                this.groupBox4.Enabled = false;
            }
            else if (this.comboBox1.SelectedItem.ToString() == "Barniz")
            {
                this.groupBox4.Visible = true;
                this.groupBox4.Enabled = true;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView4.DataSource = nuevo.MostrarProductos();
                this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView4.ScrollBars = ScrollBars.Both;
                this.dataGridView4.ForeColor = Color.Black;
                this.dataGridView4.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView4.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView4.Refresh();

                this.groupBox1.Visible = false;
                this.groupBox1.Enabled = false;
                this.groupBox2.Visible = false;
                this.groupBox2.Enabled = false;
                this.groupBox3.Visible = false;
                this.groupBox3.Enabled = false;
            }
        }
    }
}
