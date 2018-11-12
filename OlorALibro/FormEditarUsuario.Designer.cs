namespace OlorALibro
{
    partial class FormEditarUsuario
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
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelContraseñaUsuario = new System.Windows.Forms.Label();
            this.labelCorreoUsuario = new System.Windows.Forms.Label();
            this.labelTelefonoUsuario = new System.Windows.Forms.Label();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.textBoxCorreoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Location = new System.Drawing.Point(89, 156);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(44, 13);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre";
            // 
            // labelContraseñaUsuario
            // 
            this.labelContraseñaUsuario.AutoSize = true;
            this.labelContraseñaUsuario.Location = new System.Drawing.Point(89, 184);
            this.labelContraseñaUsuario.Name = "labelContraseñaUsuario";
            this.labelContraseñaUsuario.Size = new System.Drawing.Size(61, 13);
            this.labelContraseñaUsuario.TabIndex = 1;
            this.labelContraseñaUsuario.Text = "Contraseña";
            // 
            // labelCorreoUsuario
            // 
            this.labelCorreoUsuario.AutoSize = true;
            this.labelCorreoUsuario.Location = new System.Drawing.Point(89, 210);
            this.labelCorreoUsuario.Name = "labelCorreoUsuario";
            this.labelCorreoUsuario.Size = new System.Drawing.Size(38, 13);
            this.labelCorreoUsuario.TabIndex = 2;
            this.labelCorreoUsuario.Text = "Correo";
            // 
            // labelTelefonoUsuario
            // 
            this.labelTelefonoUsuario.AutoSize = true;
            this.labelTelefonoUsuario.Location = new System.Drawing.Point(89, 237);
            this.labelTelefonoUsuario.Name = "labelTelefonoUsuario";
            this.labelTelefonoUsuario.Size = new System.Drawing.Size(49, 13);
            this.labelTelefonoUsuario.TabIndex = 3;
            this.labelTelefonoUsuario.Text = "Telefono";
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(174, 155);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(241, 20);
            this.textBoxNombreUsuario.TabIndex = 4;
            // 
            // textBoxContraseñaUsuario
            // 
            this.textBoxContraseñaUsuario.Location = new System.Drawing.Point(174, 182);
            this.textBoxContraseñaUsuario.Name = "textBoxContraseñaUsuario";
            this.textBoxContraseñaUsuario.Size = new System.Drawing.Size(241, 20);
            this.textBoxContraseñaUsuario.TabIndex = 5;
            // 
            // textBoxCorreoUsuario
            // 
            this.textBoxCorreoUsuario.Location = new System.Drawing.Point(174, 209);
            this.textBoxCorreoUsuario.Name = "textBoxCorreoUsuario";
            this.textBoxCorreoUsuario.Size = new System.Drawing.Size(241, 20);
            this.textBoxCorreoUsuario.TabIndex = 6;
            // 
            // textBoxTelefonoUsuario
            // 
            this.textBoxTelefonoUsuario.Location = new System.Drawing.Point(174, 236);
            this.textBoxTelefonoUsuario.Name = "textBoxTelefonoUsuario";
            this.textBoxTelefonoUsuario.Size = new System.Drawing.Size(241, 20);
            this.textBoxTelefonoUsuario.TabIndex = 7;
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(377, 390);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(99, 23);
            this.buttonGuardarUsuario.TabIndex = 8;
            this.buttonGuardarUsuario.Text = "Guardar usuario";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = false;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGuardarUsuario_Click);
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 448);
            this.Controls.Add(this.buttonGuardarUsuario);
            this.Controls.Add(this.textBoxTelefonoUsuario);
            this.Controls.Add(this.textBoxCorreoUsuario);
            this.Controls.Add(this.textBoxContraseñaUsuario);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.Controls.Add(this.labelTelefonoUsuario);
            this.Controls.Add(this.labelCorreoUsuario);
            this.Controls.Add(this.labelContraseñaUsuario);
            this.Controls.Add(this.labelNombreUsuario);
            this.Name = "FormEditarUsuario";
            this.Text = "FormEditarUsuario";
            this.Load += new System.EventHandler(this.FormEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelContraseñaUsuario;
        private System.Windows.Forms.Label labelCorreoUsuario;
        private System.Windows.Forms.Label labelTelefonoUsuario;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxContraseñaUsuario;
        private System.Windows.Forms.TextBox textBoxCorreoUsuario;
        private System.Windows.Forms.TextBox textBoxTelefonoUsuario;
        private System.Windows.Forms.Button buttonGuardarUsuario;
    }
}