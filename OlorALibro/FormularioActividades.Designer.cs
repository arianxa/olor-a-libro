namespace OlorALibro
{
    partial class FormularioActividades
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
            this.dateTimeFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.buttonCrearActividad = new System.Windows.Forms.Button();
            this.labelDescripcionActividades = new System.Windows.Forms.Label();
            this.labelCategoriasActividades = new System.Windows.Forms.Label();
            this.labelFechaFinal = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.labelNombreActividades = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLibreriasActividades = new System.Windows.Forms.Label();
            this.textBoxNombreActividad = new System.Windows.Forms.TextBox();
            this.listBoxCategoriasActividades = new System.Windows.Forms.ListBox();
            this.listBoxLibreriasActividades = new System.Windows.Forms.ListBox();
            this.textBoxDescripcionActividades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeFechaFinal
            // 
            this.dateTimeFechaFinal.Location = new System.Drawing.Point(158, 108);
            this.dateTimeFechaFinal.Name = "dateTimeFechaFinal";
            this.dateTimeFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaFinal.TabIndex = 18;
            // 
            // dateTimeFechaInicio
            // 
            this.dateTimeFechaInicio.Location = new System.Drawing.Point(158, 73);
            this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
            this.dateTimeFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFechaInicio.TabIndex = 17;
            // 
            // buttonCrearActividad
            // 
            this.buttonCrearActividad.Location = new System.Drawing.Point(307, 400);
            this.buttonCrearActividad.Name = "buttonCrearActividad";
            this.buttonCrearActividad.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearActividad.TabIndex = 16;
            this.buttonCrearActividad.Text = "Crear";
            this.buttonCrearActividad.UseVisualStyleBackColor = true;
            this.buttonCrearActividad.Click += new System.EventHandler(this.buttonCrearActividad_Click);
            // 
            // labelDescripcionActividades
            // 
            this.labelDescripcionActividades.AutoSize = true;
            this.labelDescripcionActividades.Location = new System.Drawing.Point(24, 269);
            this.labelDescripcionActividades.Name = "labelDescripcionActividades";
            this.labelDescripcionActividades.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcionActividades.TabIndex = 15;
            this.labelDescripcionActividades.Text = "Descripción";
            // 
            // labelCategoriasActividades
            // 
            this.labelCategoriasActividades.AutoSize = true;
            this.labelCategoriasActividades.Location = new System.Drawing.Point(24, 150);
            this.labelCategoriasActividades.Name = "labelCategoriasActividades";
            this.labelCategoriasActividades.Size = new System.Drawing.Size(57, 13);
            this.labelCategoriasActividades.TabIndex = 14;
            this.labelCategoriasActividades.Text = "Categorias";
            // 
            // labelFechaFinal
            // 
            this.labelFechaFinal.AutoSize = true;
            this.labelFechaFinal.Location = new System.Drawing.Point(24, 114);
            this.labelFechaFinal.Name = "labelFechaFinal";
            this.labelFechaFinal.Size = new System.Drawing.Size(59, 13);
            this.labelFechaFinal.TabIndex = 13;
            this.labelFechaFinal.Text = "Fecha final";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Location = new System.Drawing.Point(23, 79);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(64, 13);
            this.labelFechaInicio.TabIndex = 12;
            this.labelFechaInicio.Text = "Fecha inicio";
            // 
            // labelNombreActividades
            // 
            this.labelNombreActividades.AutoSize = true;
            this.labelNombreActividades.Location = new System.Drawing.Point(24, 32);
            this.labelNombreActividades.Name = "labelNombreActividades";
            this.labelNombreActividades.Size = new System.Drawing.Size(91, 13);
            this.labelNombreActividades.TabIndex = 11;
            this.labelNombreActividades.Text = "Nombre Actividad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-17, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // labelLibreriasActividades
            // 
            this.labelLibreriasActividades.AutoSize = true;
            this.labelLibreriasActividades.Location = new System.Drawing.Point(24, 315);
            this.labelLibreriasActividades.Name = "labelLibreriasActividades";
            this.labelLibreriasActividades.Size = new System.Drawing.Size(46, 13);
            this.labelLibreriasActividades.TabIndex = 20;
            this.labelLibreriasActividades.Text = "Librerias";
            // 
            // textBoxNombreActividad
            // 
            this.textBoxNombreActividad.Location = new System.Drawing.Point(158, 24);
            this.textBoxNombreActividad.Name = "textBoxNombreActividad";
            this.textBoxNombreActividad.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreActividad.TabIndex = 21;
            // 
            // listBoxCategoriasActividades
            // 
            this.listBoxCategoriasActividades.FormattingEnabled = true;
            this.listBoxCategoriasActividades.Items.AddRange(new object[] {
            "Infantil",
            "Adultos"});
            this.listBoxCategoriasActividades.Location = new System.Drawing.Point(158, 150);
            this.listBoxCategoriasActividades.Name = "listBoxCategoriasActividades";
            this.listBoxCategoriasActividades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCategoriasActividades.Size = new System.Drawing.Size(200, 95);
            this.listBoxCategoriasActividades.TabIndex = 23;
            // 
            // listBoxLibreriasActividades
            // 
            this.listBoxLibreriasActividades.FormattingEnabled = true;
            this.listBoxLibreriasActividades.Items.AddRange(new object[] {
            "Libreria 1",
            "Libreria 2",
            "Libreria 3",
            "Libreria 4",
            "Libreria 5",
            "Libreria 6",
            "Libreria 7"});
            this.listBoxLibreriasActividades.Location = new System.Drawing.Point(158, 301);
            this.listBoxLibreriasActividades.Name = "listBoxLibreriasActividades";
            this.listBoxLibreriasActividades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxLibreriasActividades.Size = new System.Drawing.Size(200, 82);
            this.listBoxLibreriasActividades.TabIndex = 25;
            // 
            // textBoxDescripcionActividades
            // 
            this.textBoxDescripcionActividades.Location = new System.Drawing.Point(158, 262);
            this.textBoxDescripcionActividades.Multiline = true;
            this.textBoxDescripcionActividades.Name = "textBoxDescripcionActividades";
            this.textBoxDescripcionActividades.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescripcionActividades.TabIndex = 26;
            // 
            // FormularioActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 434);
            this.Controls.Add(this.textBoxDescripcionActividades);
            this.Controls.Add(this.listBoxLibreriasActividades);
            this.Controls.Add(this.listBoxCategoriasActividades);
            this.Controls.Add(this.textBoxNombreActividad);
            this.Controls.Add(this.labelLibreriasActividades);
            this.Controls.Add(this.dateTimeFechaFinal);
            this.Controls.Add(this.dateTimeFechaInicio);
            this.Controls.Add(this.buttonCrearActividad);
            this.Controls.Add(this.labelDescripcionActividades);
            this.Controls.Add(this.labelCategoriasActividades);
            this.Controls.Add(this.labelFechaFinal);
            this.Controls.Add(this.labelFechaInicio);
            this.Controls.Add(this.labelNombreActividades);
            this.Controls.Add(this.label1);
            this.Name = "FormularioActividades";
            this.Text = "FormularioActividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinal;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicio;
        private System.Windows.Forms.Button buttonCrearActividad;
        private System.Windows.Forms.Label labelDescripcionActividades;
        private System.Windows.Forms.Label labelCategoriasActividades;
        private System.Windows.Forms.Label labelFechaFinal;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.Label labelNombreActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLibreriasActividades;
        private System.Windows.Forms.TextBox textBoxNombreActividad;
        private System.Windows.Forms.ListBox listBoxCategoriasActividades;
        private System.Windows.Forms.ListBox listBoxLibreriasActividades;
        private System.Windows.Forms.TextBox textBoxDescripcionActividades;
    }
}