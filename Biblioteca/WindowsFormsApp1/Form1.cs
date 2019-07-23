using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            
           
                if (TxbUsuario.Text == "UsuarioEpn" && TxbContraseña.Text == "2412855" )
                {

                    MessageBox.Show("Sesion iniciada correctamente");

                this.Hide();

                Menu NuevaVentana = new Menu();

                NuevaVentana.Show();



                }
                
                else
                {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta ");

                TxbUsuario.Text ="";
                TxbContraseña.Text = "";    
            }


            



        }

        private void TxbUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
