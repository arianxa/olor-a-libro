namespace OlorALibro
{
    partial class FormPrincipal2
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
            this.buttonEstadisticas = new System.Windows.Forms.Button();
            this.buttonDatosDeLaRed = new System.Windows.Forms.Button();
            this.Usuarios = new System.Windows.Forms.Button();
            this.buttonActividades = new System.Windows.Forms.Button();
            this.buttonLibrerias = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEstadisticas
            // 
            this.buttonEstadisticas.Location = new System.Drawing.Point(196, 164);
            this.buttonEstadisticas.Name = "buttonEstadisticas";
            this.buttonEstadisticas.Size = new System.Drawing.Size(100, 100);
            this.buttonEstadisticas.TabIndex = 11;
            this.buttonEstadisticas.Text = "Estadisticas";
            this.buttonEstadisticas.UseVisualStyleBackColor = true;
            // 
            // buttonDatosDeLaRed
            // 
            this.buttonDatosDeLaRed.Location = new System.Drawing.Point(319, 234);
            this.buttonDatosDeLaRed.Name = "buttonDatosDeLaRed";
            this.buttonDatosDeLaRed.Size = new System.Drawing.Size(100, 100);
            this.buttonDatosDeLaRed.TabIndex = 10;
            this.buttonDatosDeLaRed.Text = "Datos de la Red";
            this.buttonDatosDeLaRed.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.Usuarios.Location = new System.Drawing.Point(65, 234);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(100, 100);
            this.Usuarios.TabIndex = 9;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // buttonActividades
            // 
            this.buttonActividades.Location = new System.Drawing.Point(319, 109);
            this.buttonActividades.Name = "buttonActividades";
            this.buttonActividades.Size = new System.Drawing.Size(100, 100);
            this.buttonActividades.TabIndex = 8;
            this.buttonActividades.Text = "Actividades";
            this.buttonActividades.UseVisualStyleBackColor = true;
            // 
            // buttonLibrerias
            // 
            this.buttonLibrerias.Location = new System.Drawing.Point(65, 109);
            this.buttonLibrerias.Name = "buttonLibrerias";
            this.buttonLibrerias.Size = new System.Drawing.Size(100, 100);
            this.buttonLibrerias.TabIndex = 7;
            this.buttonLibrerias.Text = "Librerias";
            this.buttonLibrerias.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(133, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(211, 37);
            this.labelTitulo.TabIndex = 6;
            this.labelTitulo.Text = "OLOR A LIBRO";
            this.labelTitulo.UseCompatibleTextRendering = true;
            // 
            // FormPrincipal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 361);
            this.Controls.Add(this.buttonEstadisticas);
            this.Controls.Add(this.buttonDatosDeLaRed);
            this.Controls.Add(this.Usuarios);
            this.Controls.Add(this.buttonActividades);
            this.Controls.Add(this.buttonLibrerias);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormPrincipal2";
            this.Text = "FormPrincipal2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEstadisticas;
        private System.Windows.Forms.Button buttonDatosDeLaRed;
        private System.Windows.Forms.Button Usuarios;
        private System.Windows.Forms.Button buttonActividades;
        private System.Windows.Forms.Button buttonLibrerias;
        private System.Windows.Forms.Label labelTitulo;
    }
}