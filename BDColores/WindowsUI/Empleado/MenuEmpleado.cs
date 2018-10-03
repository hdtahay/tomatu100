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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            AgregarMostrarEmpleado fh = new AgregarMostrarEmpleado();
            fh.label7.Text = 1.ToString();
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
            AgregarMostrarEmpleado fh = new AgregarMostrarEmpleado();
            fh.label7.Text = 2.ToString();
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
            ModificarEliminarEmpleado fh = new ModificarEliminarEmpleado();
            fh.label7.Text = 4.ToString();
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
            ModificarEliminarEmpleado fh = new ModificarEliminarEmpleado();
            fh.label7.Text = 3.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }
    }
}
