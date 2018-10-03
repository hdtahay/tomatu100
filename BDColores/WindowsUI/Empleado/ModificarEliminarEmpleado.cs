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
    public partial class ModificarEliminarEmpleado : Form
    {
        public ModificarEliminarEmpleado()
        {
            InitializeComponent();
            label7.Visible = false;
            label8.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            this.dataGridView2.Enabled = false;
            ClassColorBLL nuevo = new ClassColorBLL();
            this.dataGridView2.DataSource = nuevo.MostrarEmpleados();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ScrollBars = ScrollBars.Both;
            this.dataGridView2.ForeColor = Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.Refresh();
        }

        private void ModificarEliminarEmpleado_Load(object sender, EventArgs e)
        {
            if (label7.Text == "3")
            {
                groupBox1.Enabled = true;
                this.dataGridView2.Enabled = true;
            }
            else if (label7.Text == "4")
            {
                groupBox2.Enabled = true;
                button2.Enabled = false;
                ClassColorBLL nuevo = new ClassColorBLL();
                this.dataGridView1.DataSource = nuevo.MostrarEmpleados();
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                this.dataGridView1.ScrollBars = ScrollBars.Both;
                this.dataGridView1.ForeColor = Color.Black;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
                this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                this.dataGridView1.Refresh();
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            this.dataGridView2.Visible = false;
            ClassColorBLL nuevo = new ClassColorBLL();
            MODELS.Empleado empleado = new MODELS.Empleado();
            label8.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            groupBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassColorBLL nuevo = new ClassColorBLL();
            MODELS.Empleado empleado = new MODELS.Empleado();
            empleado.EmpleadoId = Convert.ToInt32(this.label8.Text);
            empleado.nombre_empleado = textBox1.Text;
            empleado.apellido_empleado = textBox2.Text;
            empleado.direccion_empleado = textBox3.Text;
            empleado.telefono_empleado = textBox5.Text;
            empleado.estado_empleado = true;
            nuevo.ActualizarEmpleado(empleado);
            MessageBox.Show("Empleado modificado con éxito.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            groupBox1.Enabled = false;
            dataGridView2.Visible = true;
            this.dataGridView2.DataSource = nuevo.MostrarEmpleados();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ScrollBars = ScrollBars.Both;
            this.dataGridView2.ForeColor = Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value) == 0)
            {
                ClassColorBLL nuevo = new ClassColorBLL();
                MODELS.Empleado empleado = new MODELS.Empleado();
                empleado.EmpleadoId = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                empleado.nombre_empleado = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                empleado.apellido_empleado = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                empleado.estado_empleado = false;
                empleado.direccion_empleado = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                empleado.telefono_empleado = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                nuevo.EliminarEmpleado(empleado);
                MessageBox.Show("Empleado eliminado exitosamente.");
                this.dataGridView1.DataSource = nuevo.MostrarEmpleados();
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
    }
}
