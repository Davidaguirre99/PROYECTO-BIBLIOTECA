using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

            if (TxbUsuario.Text == "UsuarioEpn" && TxbContraseña.Text == "2412855")
            {

                MessageBox.Show("Sesion iniciada correctamente");

                this.Hide();

                Menu NuevaVentana = new Menu();

                NuevaVentana.Show();



            }

            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta ");

                TxbUsuario.Text = "";
                TxbContraseña.Text = "";
            }

        }

        private void TxbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaRegistro registrar = new ventanaRegistro();
            registrar.Show();
        }
    }
}
