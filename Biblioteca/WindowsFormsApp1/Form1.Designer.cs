namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxbUsuario = new System.Windows.Forms.TextBox();
            this.TxbContraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(306, 86);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(121, 38);
            this.BtnEntrar.TabIndex = 0;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxbUsuario
            // 
            this.TxbUsuario.Location = new System.Drawing.Point(133, 56);
            this.TxbUsuario.Name = "TxbUsuario";
            this.TxbUsuario.Size = new System.Drawing.Size(141, 20);
            this.TxbUsuario.TabIndex = 1;
            // 
            // TxbContraseña
            // 
            this.TxbContraseña.Location = new System.Drawing.Point(133, 138);
            this.TxbContraseña.Name = "TxbContraseña";
            this.TxbContraseña.PasswordChar = '*';
            this.TxbContraseña.Size = new System.Drawing.Size(141, 20);
            this.TxbContraseña.TabIndex = 2;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(46, 56);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(214)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(465, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TxbContraseña);
            this.Controls.Add(this.TxbUsuario);
            this.Controls.Add(this.BtnEntrar);
            this.Name = "Form1";
            this.Text = "Logeate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox TxbUsuario;
        private System.Windows.Forms.TextBox TxbContraseña;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label1;
    }
}

