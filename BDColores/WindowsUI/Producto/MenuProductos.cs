using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI.Producto.Sub_Producto;

namespace WindowsUI
{
    public partial class MenuProductos : Form
    {
        public MenuProductos()
        {
            InitializeComponent();
        }

        private void AbrirForm(object form)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            AgregarProducto fh = new AgregarProducto();
            fh.label7.Text = 1.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            AgregarProducto fh = new AgregarProducto();
            fh.label7.Text = 2.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            ModificarProducto fh = new ModificarProducto();
            fh.label7.Text = 3.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0); //Cerramos cualquiero form abierto
            }
            ModificarProducto fh = new ModificarProducto();
            fh.label7.Text = 4.ToString();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirForm(new AgregarSubProducto());
        }
    }
}
