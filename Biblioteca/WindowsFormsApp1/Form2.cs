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
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class ventanaRegistro : Form
    {
        public ventanaRegistro()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Login regresologin = new Login();
            regresologin.Show();
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximo.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximo.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {

            string Usuario = "Nombres:" + txbNombres.Text + " " + "Apellidos:" + txbApellidos.Text +" "+ "Clave:" + TxbContraseña.Text +" "+ "Confirmacion:" + txbConfirmacionContraseña.Text +" " +"Fecha de Nacimiento:" + txbdia.Text + txbMes.Text + txbAnio.Text;
            string cadenas = txbNombres.Text + txbApellidos.Text ;
            string contraseña = TxbContraseña.Text;
            string numeros =  txbdia.Text + txbMes.Text + txbAnio.Text;
            bool ValidacionNumerica=false;
            bool validaciontotal = false;
            if(contraseña != txbConfirmacionContraseña.Text)
            {
                string cadenasmal = "Las contraseñas no coinciden, porfavor ingreselas de nuevo";
                MessageBoxIcon Icon = MessageBoxIcon.Question;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(cadenasmal, "Error", botones, Icon);
                validaciontotal = false;

            }
            else
            {
                validaciontotal = true;
            }
            if(txbAnio.Text==""||txbApellidos.Text==""||txbNombres.Text==""||
                txbdia.Text==""||txbMes.Text==""||TxbContraseña.Text==""||txbConfirmacionContraseña.Text=="")
            {
                string cadenasmal = "Ciertos casilleros faltan completar, Porfavor Ingrese los datos restantes";
                MessageBoxIcon Icon = MessageBoxIcon.Question;
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(cadenasmal, "Error", botones, Icon);
                validaciontotal = false;
            }else
            {
                if(validaciontotal==false)
                {
                   
                }else
                {
                    validaciontotal = true;
                }
            }
                
            
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == '0' || cadenas[i] == '1' || cadenas[i] == '2' || cadenas[i] == '3' ||
                    cadenas[i] == '4' || cadenas[i] == '5' || cadenas[i] == '6' || cadenas[i] == '7' ||
                        cadenas[i] == '8' || cadenas[i] == '9')
                {
                    string cadenasmal = "Ciertos datos ingresados no contienen un formato adecuado, Porfavor Ingrese Datos Validos";
                    MessageBoxIcon Icon = MessageBoxIcon.Question;
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show(cadenasmal, "Error", botones, Icon);
                    validaciontotal = false;
                    break;
                }
             }
            for (int j = 0; j < numeros.Length;j++)
                {
                    if (numeros[j] == '0' || numeros[j] == '1' || numeros[j] == '2' || numeros[j] == '3' ||
                    numeros[j] == '4' || numeros[j] == '5' || numeros[j] == '6' || numeros[j] == '7' ||
                        numeros[j] == '8' || numeros[j] == '9')
                    {
                        
                    }
                    else
                    {
                        ValidacionNumerica = true;
                        string cadenasmal = "Ciertos datos ingresados no contienen un formato adecuado, Porfavor Ingrese Datos Validos";
                        MessageBoxIcon Icon = MessageBoxIcon.Question;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(cadenasmal, "Error", botones, Icon);
                        validaciontotal = false;
                        break;
                        
                    }
                }
                if(ValidacionNumerica== false & validaciontotal==true)
                {
                    
                    int dia = Int32.Parse(txbdia.Text);
                    int mes = Int32.Parse(txbMes.Text);
                    int anio = Int32.Parse(txbAnio.Text);
                    int verificaredad = 2019 - anio;
                    int aniobisiesto = anio % 4;
                    if (mes>12||mes<=0||dia<=0)
                    {
                        string cadenasmal = "Ciertos datos ingresados no concuerdadn, Porfavor Ingrese Datos Reales";
                        MessageBoxIcon Icon = MessageBoxIcon.Question;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(cadenasmal, "Error", botones, Icon);
                        validaciontotal = false;
                        
                    }
                    else
                    {
                        if (mes==2 & aniobisiesto==0 & dia>29)
                        {
                            string cadenasmal = "Ciertos datos ingresados no concuerdadn, Porfavor Ingrese Datos Reales";
                            MessageBoxIcon Icon = MessageBoxIcon.Question;
                            MessageBoxButtons botones = MessageBoxButtons.OK;
                            MessageBox.Show(cadenasmal, "Error", botones, Icon);
                            validaciontotal = false;
                          
                        }
                        else
                        {
                            if(mes==2 & aniobisiesto!=0 &dia>28)
                            {
                                string cadenasmal = "Ciertos datos ingresados no concuerdadn, Porfavor Ingrese Datos Reales";
                                MessageBoxIcon Icon = MessageBoxIcon.Question;
                                MessageBoxButtons botones = MessageBoxButtons.OK;
                                MessageBox.Show(cadenasmal, "Error", botones, Icon);
                                validaciontotal = false;
                                
                            }else
                            {
                                validaciontotal = true;
                            }
                        }
                    }

                }

            string libreria = @"D:\DAVID PRGRA\PROYECTO BIBLIOTECA\PROYECTO-BIBLIOTECA\Biblioteca\WindowsFormsApp1\Usuarios\TextFile1.txt";
            StreamWriter esribir = File.CreateText(libreria);
            esribir.Close();
            string[] textoarray = File.ReadAllLines(libreria);
            string contrasenia = "Clave:" + TxbContraseña.Text;
            foreach (string lineaguardada in textoarray)
            {
                string[] partesdelinea = lineaguardada.Split(' ');
                for (int i = 0; i < partesdelinea.Length;i++)
                {
                    if (partesdelinea[i] == contrasenia)
                    {
                        string cadenasmal = "La contraseña que ha escrito ya esta siendo usada porfavor ingrese otra";
                        MessageBoxIcon Icon = MessageBoxIcon.Question;
                        MessageBoxButtons botones = MessageBoxButtons.OK;
                        MessageBox.Show(cadenasmal, "Error", botones, Icon);
                        validaciontotal = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            if (validaciontotal==true)
                {
                    MessageBoxIcon Icon = MessageBoxIcon.Question;
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show("Correcto", "Error", botones, Icon);
                string libreriaorigen = @"D:\DAVID PRGRA\PROYECTO BIBLIOTECA\PROYECTO-BIBLIOTECA\Biblioteca\WindowsFormsApp1\Usuarios\TextFile1.txt";
                //string contrasenia = TxbContraseña.Text;
                //string[] textoarray = File.ReadAllLines(libreria);
                String Resultado = File.ReadAllText(libreriaorigen);
                StreamWriter escribir = File.CreateText(libreriaorigen);
                // string Usuarios = "Autor:" + txbNombres.Text + "  Duracion:" + txbApellidos.Text + "  Instrumentos:" + txb.Text;
                        escribir.WriteLine(Resultado + Usuario);
                        escribir.Close();
                }
                
               
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbNombres_TextChanged(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wmsg, int wParam, int lParam);

        private void barradeTitulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
