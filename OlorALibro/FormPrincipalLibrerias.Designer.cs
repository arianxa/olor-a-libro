namespace OlorALibro
{
    partial class FormPrincipalLibrerias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalLibrerias));
            this.label1 = new System.Windows.Forms.Label();
            this.imageListPrincipalLibrerias = new System.Windows.Forms.ImageList(this.components);
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewPrincipalLibrerias = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipalLibrerias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Librerias";
            // 
            // imageListPrincipalLibrerias
            // 
            this.imageListPrincipalLibrerias.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPrincipalLibrerias.ImageStream")));
            this.imageListPrincipalLibrerias.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPrincipalLibrerias.Images.SetKeyName(0, "editar.png");
            this.imageListPrincipalLibrerias.Images.SetKeyName(1, "eliminar.png");
            this.imageListPrincipalLibrerias.Images.SetKeyName(2, "mas.png");
            this.imageListPrincipalLibrerias.Images.SetKeyName(3, "usuario.png");
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.AccessibleDescription = "";
            this.buttonAñadir.AccessibleName = "";
            this.buttonAñadir.ImageIndex = 2;
            this.buttonAñadir.ImageList = this.imageListPrincipalLibrerias;
            this.buttonAñadir.Location = new System.Drawing.Point(103, 148);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(63, 42);
            this.buttonAñadir.TabIndex = 3;
            this.buttonAñadir.Tag = "";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ImageIndex = 1;
            this.buttonEliminar.ImageList = this.imageListPrincipalLibrerias;
            this.buttonEliminar.Location = new System.Drawing.Point(172, 148);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(61, 42);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.ImageIndex = 0;
            this.buttonEditar.ImageList = this.imageListPrincipalLibrerias;
            this.buttonEditar.Location = new System.Drawing.Point(239, 148);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEditar.Size = new System.Drawing.Size(62, 42);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewPrincipalLibrerias
            // 
            this.dataGridViewPrincipalLibrerias.AllowUserToAddRows = false;
            this.dataGridViewPrincipalLibrerias.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipalLibrerias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrincipalLibrerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipalLibrerias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.direccion,
            this.telefono,
            this.nombrecontacto});
            this.dataGridViewPrincipalLibrerias.Location = new System.Drawing.Point(103, 223);
            this.dataGridViewPrincipalLibrerias.Name = "dataGridViewPrincipalLibrerias";
            this.dataGridViewPrincipalLibrerias.ReadOnly = true;
            this.dataGridViewPrincipalLibrerias.RowTemplate.Height = 29;
            this.dataGridViewPrincipalLibrerias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipalLibrerias.Size = new System.Drawing.Size(645, 262);
            this.dataGridViewPrincipalLibrerias.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // nombrecontacto
            // 
            this.nombrecontacto.DataPropertyName = "nombreContacto";
            this.nombrecontacto.HeaderText = "Nombre de Contacto";
            this.nombrecontacto.Name = "nombrecontacto";
            this.nombrecontacto.ReadOnly = true;
            // 
            // FormPrincipalLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 511);
            this.Controls.Add(this.dataGridViewPrincipalLibrerias);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipalLibrerias";
            this.Text = "FormPrincipalLibrerias";
            this.Activated += new System.EventHandler(this.FormPrincipalLibrerias_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalLibrerias_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipalLibrerias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipalLibrerias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListPrincipalLibrerias;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewPrincipalLibrerias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecontacto;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}