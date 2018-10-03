using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI;

namespace WindowsUI
{
    public partial class MenuColores : Form
    {
        public MenuColores()
        {
            InitializeComponent();
            AbrirForm(new FormInicio());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirForm(object form)
        {
            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormInicio());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm(new MenuEmpleado());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new MenuProductos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new MenuCliente());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new Venta.MenuVenta());
        }
    }
}
