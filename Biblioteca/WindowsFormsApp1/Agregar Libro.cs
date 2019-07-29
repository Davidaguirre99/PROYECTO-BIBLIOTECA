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
    public partial class Agregar_Libro : Form
    {
        public Agregar_Libro()
        {
            InitializeComponent();
        }
        string path = @"C:\Libro\DatosLibros.txt";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = TxbNombre.Text;
                string fecha = TxbFecha.Text;
                string genero = TxbGenero.Text;

                string libros = "Nombre:" + nombre + "|Fecha:" + fecha + "|Genero:" + genero;

                string[] RegistroLibrosArray = File.ReadAllLines(path);
                String registroFinal = File.ReadAllText(path);
                StreamWriter escritura = File.CreateText(path);
                escritura.WriteLine(registroFinal + libros);
                escritura.Close();
            }
            catch(Exception )
            {
                MessageBox.Show("A ocurrido un error :");


            }
            
        }
    }
}
