namespace OlorALibro
{
    partial class FormularioPrincipalActividades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipalActividades));
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.NomActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelTituloActividades = new System.Windows.Forms.Label();
            this.buttonModificarActividades = new System.Windows.Forms.Button();
            this.buttonEliminarActividades = new System.Windows.Forms.Button();
            this.buttonAñadirActividades = new System.Windows.Forms.Button();
            this.LogoPrincipalActividades = new System.Windows.Forms.PictureBox();
            this.buttonSalirActividad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.AllowUserToAddRows = false;
            this.dataGridViewActividades.AllowUserToDeleteRows = false;
            this.dataGridViewActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActividades.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewActividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomActividad,
            this.dataInicio,
            this.dataFinal,
            this.Categoria});
            this.dataGridViewActividades.Location = new System.Drawing.Point(76, 159);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.ReadOnly = true;
            this.dataGridViewActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActividades.Size = new System.Drawing.Size(421, 248);
            this.dataGridViewActividades.TabIndex = 11;
            // 
            // NomActividad
            // 
            this.NomActividad.DataPropertyName = "nombre";
            this.NomActividad.HeaderText = "Nombre";
            this.NomActividad.Name = "NomActividad";
            this.NomActividad.ReadOnly = true;
            // 
            // dataInicio
            // 
            this.dataInicio.DataPropertyName = "fechaInicio";
            this.dataInicio.HeaderText = "Fecha inicio";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            // 
            // dataFinal
            // 
            this.dataFinal.DataPropertyName = "fechaFinal";
            this.dataFinal.HeaderText = "Fecha final";
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "categorias";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "editar.png");
            this.imageList1.Images.SetKeyName(1, "eliminar.png");
            this.imageList1.Images.SetKeyName(2, "mas.png");
            this.imageList1.Images.SetKeyName(3, "usuario.png");
            this.imageList1.Images.SetKeyName(4, "Salir.png");
            this.imageList1.Images.SetKeyName(5, "logo.png");
            // 
            // labelTituloActividades
            // 
            this.labelTituloActividades.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloActividades.Location = new System.Drawing.Point(141, 9);
            this.labelTituloActividades.Name = "labelTituloActividades";
            this.labelTituloActividades.Padding = new System.Windows.Forms.Padding(20, 5, 10, 10);
            this.labelTituloActividades.Size = new System.Drawing.Size(426, 88);
            this.labelTituloActividades.TabIndex = 7;
            this.labelTituloActividades.Text = "ACTIVIDADES";
            // 
            // buttonModificarActividades
            // 
            this.buttonModificarActividades.ImageIndex = 0;
            this.buttonModificarActividades.ImageList = this.imageList1;
            this.buttonModificarActividades.Location = new System.Drawing.Point(154, 120);
            this.buttonModificarActividades.Name = "buttonModificarActividades";
            this.buttonModificarActividades.Size = new System.Drawing.Size(33, 33);
            this.buttonModificarActividades.TabIndex = 10;
            this.buttonModificarActividades.UseVisualStyleBackColor = true;
            this.buttonModificarActividades.Click += new System.EventHandler(this.buttonModificarActividades_Click);
            // 
            // buttonEliminarActividades
            // 
            this.buttonEliminarActividades.ImageIndex = 1;
            this.buttonEliminarActividades.ImageList = this.imageList1;
            this.buttonEliminarActividades.Location = new System.Drawing.Point(115, 120);
            this.buttonEliminarActividades.Name = "buttonEliminarActividades";
            this.buttonEliminarActividades.Size = new System.Drawing.Size(33, 33);
            this.buttonEliminarActividades.TabIndex = 9;
            this.buttonEliminarActividades.UseVisualStyleBackColor = true;
            this.buttonEliminarActividades.Click += new System.EventHandler(this.buttonEliminarActividades_Click);
            // 
            // buttonAñadirActividades
            // 
            this.buttonAñadirActividades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAñadirActividades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAñadirActividades.ImageIndex = 2;
            this.buttonAñadirActividades.ImageList = this.imageList1;
            this.buttonAñadirActividades.Location = new System.Drawing.Point(76, 120);
            this.buttonAñadirActividades.Name = "buttonAñadirActividades";
            this.buttonAñadirActividades.Size = new System.Drawing.Size(33, 33);
            this.buttonAñadirActividades.TabIndex = 8;
            this.buttonAñadirActividades.UseVisualStyleBackColor = false;
            this.buttonAñadirActividades.Click += new System.EventHandler(this.buttonAñadirActividades_Click);
            // 
            // LogoPrincipalActividades
            // 
            this.LogoPrincipalActividades.Image = ((System.Drawing.Image)(resources.GetObject("LogoPrincipalActividades.Image")));
            this.LogoPrincipalActividades.Location = new System.Drawing.Point(-1, -3);
            this.LogoPrincipalActividades.Name = "LogoPrincipalActividades";
            this.LogoPrincipalActividades.Size = new System.Drawing.Size(123, 117);
            this.LogoPrincipalActividades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPrincipalActividades.TabIndex = 6;
            this.LogoPrincipalActividades.TabStop = false;
            // 
            // buttonSalirActividad
            // 
            this.buttonSalirActividad.ImageIndex = 4;
            this.buttonSalirActividad.ImageList = this.imageList1;
            this.buttonSalirActividad.Location = new System.Drawing.Point(193, 120);
            this.buttonSalirActividad.Name = "buttonSalirActividad";
            this.buttonSalirActividad.Size = new System.Drawing.Size(33, 33);
            this.buttonSalirActividad.TabIndex = 12;
            this.buttonSalirActividad.UseVisualStyleBackColor = true;
            this.buttonSalirActividad.Click += new System.EventHandler(this.buttonSalirActividad_Click);
            // 
            // FormularioPrincipalActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 409);
            this.Controls.Add(this.buttonSalirActividad);
            this.Controls.Add(this.dataGridViewActividades);
            this.Controls.Add(this.buttonModificarActividades);
            this.Controls.Add(this.buttonEliminarActividades);
            this.Controls.Add(this.buttonAñadirActividades);
            this.Controls.Add(this.labelTituloActividades);
            this.Controls.Add(this.LogoPrincipalActividades);
            this.Name = "FormularioPrincipalActividades";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FormularioPrincipalActividades_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormularioPrincipalActividades_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPrincipalActividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPrincipalActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.Button buttonModificarActividades;
        private System.Windows.Forms.Button buttonEliminarActividades;
        private System.Windows.Forms.Button buttonAñadirActividades;
        private System.Windows.Forms.Label labelTituloActividades;
        private System.Windows.Forms.PictureBox LogoPrincipalActividades;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonSalirActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}

