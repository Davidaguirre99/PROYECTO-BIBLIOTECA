namespace WindowsFormsApp1
{
    partial class Agregar_Libro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAgregarLibro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbGenero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAgregarLibro
            // 
            this.BtnAgregarLibro.Location = new System.Drawing.Point(378, 87);
            this.BtnAgregarLibro.Name = "BtnAgregarLibro";
            this.BtnAgregarLibro.Size = new System.Drawing.Size(126, 31);
            this.BtnAgregarLibro.TabIndex = 0;
            this.BtnAgregarLibro.Text = "Agregar Libro";
            this.BtnAgregarLibro.UseVisualStyleBackColor = true;
            this.BtnAgregarLibro.Click += new System.EventHandler(this.BtnAgregarLibro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // TxbNombre
            // 
            this.TxbNombre.Location = new System.Drawing.Point(132, 40);
            this.TxbNombre.Name = "TxbNombre";
            this.TxbNombre.Size = new System.Drawing.Size(100, 20);
            this.TxbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // TxbFecha
            // 
            this.TxbFecha.Location = new System.Drawing.Point(132, 84);
            this.TxbFecha.Name = "TxbFecha";
            this.TxbFecha.Size = new System.Drawing.Size(100, 20);
            this.TxbFecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero";
            // 
            // TxbGenero
            // 
            this.TxbGenero.Location = new System.Drawing.Point(132, 132);
            this.TxbGenero.Name = "TxbGenero";
            this.TxbGenero.Size = new System.Drawing.Size(100, 20);
            this.TxbGenero.TabIndex = 6;
            // 
            // Agregar_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 272);
            this.Controls.Add(this.TxbGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregarLibro);
            this.Name = "Agregar_Libro";
            this.Text = "Agregar_Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbGenero;
    }
}