﻿using System;
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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            label7.Visible = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            if (label7.Text == "1")
            {
                groupBox2.Enabled = true;
            }
            else if (label7.Text == "2")
            {
                groupBox1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            ClassColorBLL nuevo = new ClassColorBLL();
            this.dataGridView1.DataSource = nuevo.BuscaProducto(this.textBox4.Text);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ScrollBars = ScrollBars.Both;
            this.dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.Refresh();
            textBox4.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassColorBLL nuevo = new ClassColorBLL();
            string respuesta;
            respuesta = nuevo.NuevoProducto(this.textBox1.Text, this.richTextBox1.Text, Convert.ToInt32(this.textBox5.Text));
            MessageBox.Show(respuesta);
            textBox1.Clear();
            textBox5.Clear();
            richTextBox1.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
