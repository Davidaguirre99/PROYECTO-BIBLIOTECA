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
            string libreria = @"D:\DAVID PRGRA\PROYECTO BIBLIOTECA\PROYECTO-BIBLIOTECA\Biblioteca\WindowsFormsApp1\Usuarios\TextFile1.txt";
            string[] textoarray = File.ReadAllLines(libreria);
            string contrasenia = "Clave:" + TxbContraseña.Text;
            string nombres = "Nombres:" + TxbUsuario.Text;
            string apellidos = "Apellidos:" + TxbUsuario.Text;
            int contador = 0;
            foreach (string lineaguardada in textoarray)
            {
                string[] partesdelinea = lineaguardada.Split(' ');
                string[] partesdeusuario = nombres.Split(' ');
                for (int i = 0; i < partesdelinea.Length; i++)
                {
                    if (partesdelinea[i] == partesdeusuario[0]|| partesdelinea[i] == partesdeusuario[1]||partesdelinea[i] == contrasenia)
                    {
                        if (contador==3)
                        {
                            MessageBox.Show("Sesion iniciada correctamente");

                            this.Hide();

                            Menu NuevaVentana = new Menu();

                            NuevaVentana.Show();
                            break;
                        }else
                        {
                           
                            contador++;
                            continue;
                        }
                        
                    }
                    else
                    {
                        
                            continue;
                    }
                }
              if(contador<3)
                {
                    contador = 0;
                    continue;
                }
            }
            if(contador==0)
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta ");

                TxbUsuario.Text = "";
                TxbContraseña.Text = "";
            }
            else
            {
                MessageBox.Show("Sesion iniciada correctamente");

                this.Hide();

                Menu NuevaVentana = new Menu();

                NuevaVentana.Show();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
           ventanaRegistro ventanaRegistro = new ventanaRegistro();
            ventanaRegistro.Show();
        }
    }
}
