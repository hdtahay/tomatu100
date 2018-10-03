using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            AgregarCliente fh = new AgregarCliente();
            fh.label6.Text = 1.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            AgregarCliente fh = new AgregarCliente();
            fh.label6.Text = 2.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            Modificar_Cliente fh = new Modificar_Cliente();
            fh.label6.Text = 3.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            Modificar_Cliente fh = new Modificar_Cliente();
            fh.label6.Text = 4.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }
    }
}
