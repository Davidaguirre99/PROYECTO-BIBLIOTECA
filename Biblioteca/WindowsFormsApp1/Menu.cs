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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAgregarLibro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(191)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BtnAgregarLibro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 345);
            this.panel2.TabIndex = 1;
            // 
            // BtnAgregarLibro
            // 
            this.BtnAgregarLibro.FlatAppearance.BorderSize = 0;
            this.BtnAgregarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.BtnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarLibro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarLibro.Location = new System.Drawing.Point(3, 64);
            this.BtnAgregarLibro.Name = "BtnAgregarLibro";
            this.BtnAgregarLibro.Size = new System.Drawing.Size(197, 32);
            this.BtnAgregarLibro.TabIndex = 2;
            this.BtnAgregarLibro.Text = "Agregar Libro";
            this.BtnAgregarLibro.UseVisualStyleBackColor = true;
            this.BtnAgregarLibro.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 32);
            this.panel3.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Comedia";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Aventura";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Terror";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Ciencia Ficción";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.panel4.Location = new System.Drawing.Point(0, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 32);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.panel5.Location = new System.Drawing.Point(0, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 32);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.panel6.Location = new System.Drawing.Point(0, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 32);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(79)))), ((int)(((byte)(10)))));
            this.panel7.Location = new System.Drawing.Point(0, 263);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 32);
            this.panel7.TabIndex = 8;
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(83)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(845, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Agregar un libro nuevo
        {
            Agregar_Libro NuevaVentana1 = new Agregar_Libro();

            NuevaVentana1.Show();
        }
    }
}
