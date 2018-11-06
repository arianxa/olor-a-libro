namespace OlorALibro
{
    partial class FormRellenarLibrerias
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
            this.textBoxnombrecontacto = new System.Windows.Forms.TextBox();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.textBoxdireccion = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelNombreContacto = new System.Windows.Forms.Label();
            this.groupBoxRellenarDatos = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.groupBoxRellenarDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxnombrecontacto
            // 
            this.textBoxnombrecontacto.Location = new System.Drawing.Point(252, 217);
            this.textBoxnombrecontacto.Name = "textBoxnombrecontacto";
            this.textBoxnombrecontacto.Size = new System.Drawing.Size(165, 27);
            this.textBoxnombrecontacto.TabIndex = 0;
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(252, 157);
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.Size = new System.Drawing.Size(165, 27);
            this.textBoxtelefono.TabIndex = 1;
            // 
            // textBoxdireccion
            // 
            this.textBoxdireccion.Location = new System.Drawing.Point(252, 104);
            this.textBoxdireccion.Name = "textBoxdireccion";
            this.textBoxdireccion.Size = new System.Drawing.Size(165, 27);
            this.textBoxdireccion.TabIndex = 2;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(252, 54);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(165, 27);
            this.textBoxnombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(60, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 20);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Location = new System.Drawing.Point(60, 164);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(73, 20);
            this.labeltelefono.TabIndex = 5;
            this.labeltelefono.Text = "Telefono";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Location = new System.Drawing.Point(60, 111);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(81, 20);
            this.labeldireccion.TabIndex = 6;
            this.labeldireccion.Text = "Direccion";
            // 
            // labelNombreContacto
            // 
            this.labelNombreContacto.AutoSize = true;
            this.labelNombreContacto.Location = new System.Drawing.Point(60, 220);
            this.labelNombreContacto.Name = "labelNombreContacto";
            this.labelNombreContacto.Size = new System.Drawing.Size(163, 20);
            this.labelNombreContacto.TabIndex = 7;
            this.labelNombreContacto.Text = "Nombre de Contacto";
            // 
            // groupBoxRellenarDatos
            // 
            this.groupBoxRellenarDatos.Controls.Add(this.buttonAceptar);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxtelefono);
            this.groupBoxRellenarDatos.Controls.Add(this.labelNombreContacto);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxnombrecontacto);
            this.groupBoxRellenarDatos.Controls.Add(this.labeldireccion);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxdireccion);
            this.groupBoxRellenarDatos.Controls.Add(this.labeltelefono);
            this.groupBoxRellenarDatos.Controls.Add(this.textBoxnombre);
            this.groupBoxRellenarDatos.Controls.Add(this.labelNombre);
            this.groupBoxRellenarDatos.Location = new System.Drawing.Point(49, 12);
            this.groupBoxRellenarDatos.Name = "groupBoxRellenarDatos";
            this.groupBoxRellenarDatos.Size = new System.Drawing.Size(476, 378);
            this.groupBoxRellenarDatos.TabIndex = 8;
            this.groupBoxRellenarDatos.TabStop = false;
            this.groupBoxRellenarDatos.Text = "Rellenar Datos ";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(352, 309);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(86, 43);
            this.buttonAceptar.TabIndex = 8;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormRellenarLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 460);
            this.Controls.Add(this.groupBoxRellenarDatos);
            this.Name = "FormRellenarLibrerias";
            this.Text = "FormRellenarLibrerias";
            this.groupBoxRellenarDatos.ResumeLayout(false);
            this.groupBoxRellenarDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxnombrecontacto;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.TextBox textBoxdireccion;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelNombreContacto;
        private System.Windows.Forms.GroupBox groupBoxRellenarDatos;
        private System.Windows.Forms.Button buttonAceptar;
    }
}