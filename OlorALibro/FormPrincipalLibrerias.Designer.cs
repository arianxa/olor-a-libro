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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageListPrincipalLibrerias = new System.Windows.Forms.ImageList(this.components);
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.NombreContacto});
            this.dataGridView1.Location = new System.Drawing.Point(103, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(622, 298);
            this.dataGridView1.TabIndex = 1;
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
            this.buttonAñadir.ImageIndex = 2;
            this.buttonAñadir.ImageList = this.imageListPrincipalLibrerias;
            this.buttonAñadir.Location = new System.Drawing.Point(103, 148);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(63, 42);
            this.buttonAñadir.TabIndex = 3;
            this.buttonAñadir.UseVisualStyleBackColor = true;
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
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 300F;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 125;
            // 
            // NombreContacto
            // 
            this.NombreContacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NombreContacto.DefaultCellStyle = dataGridViewCellStyle1;
            this.NombreContacto.HeaderText = "Nombre Contacto";
            this.NombreContacto.Name = "NombreContacto";
            // 
            // FormPrincipalLibrerias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 511);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormPrincipalLibrerias";
            this.Text = "FormPrincipalLibrerias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageListPrincipalLibrerias;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreContacto;
    }
}