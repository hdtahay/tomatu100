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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre Usuario")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nombre Usuario";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Contraseña";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassTSQL lg = new ClassTSQL();
            int res = lg.Login(this.textBox1.Text, this.textBox2.Text);
            if (res > 0)
            {
                MessageBox.Show("Bienvenido");
                MenuColores nuevo = new MenuColores();
                nuevo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
                textBox1.Text = "Nombre Usuario";
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Contraseña";
            }
        }
    }
}
