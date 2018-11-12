namespace OlorALibro
{
    partial class FormUsuarios
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
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTituloUsuarios = new System.Windows.Forms.Label();
            this.buttonBorrarUsuarios = new System.Windows.Forms.Button();
            this.buttonEditarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.contraseña,
            this.correo,
            this.telefono});
            this.dataGridViewUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(26, 163);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(640, 329);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // contraseña
            // 
            this.contraseña.DataPropertyName = "contraseña";
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // labelTituloUsuarios
            // 
            this.labelTituloUsuarios.AutoSize = true;
            this.labelTituloUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.labelTituloUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTituloUsuarios.Location = new System.Drawing.Point(398, 9);
            this.labelTituloUsuarios.Name = "labelTituloUsuarios";
            this.labelTituloUsuarios.Size = new System.Drawing.Size(268, 54);
            this.labelTituloUsuarios.TabIndex = 1;
            this.labelTituloUsuarios.Text = "USUARIOS";
            // 
            // buttonBorrarUsuarios
            // 
            this.buttonBorrarUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBorrarUsuarios.Location = new System.Drawing.Point(171, 114);
            this.buttonBorrarUsuarios.Name = "buttonBorrarUsuarios";
            this.buttonBorrarUsuarios.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarUsuarios.TabIndex = 2;
            this.buttonBorrarUsuarios.Text = "Borrar";
            this.buttonBorrarUsuarios.UseVisualStyleBackColor = true;
            this.buttonBorrarUsuarios.Click += new System.EventHandler(this.buttonBorrarUsuarios_Click);
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEditarUsuario.Location = new System.Drawing.Point(285, 113);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarUsuario.TabIndex = 3;
            this.buttonEditarUsuario.Text = "Editar";
            this.buttonEditarUsuario.UseVisualStyleBackColor = true;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(678, 504);
            this.Controls.Add(this.buttonEditarUsuario);
            this.Controls.Add(this.buttonBorrarUsuarios);
            this.Controls.Add(this.labelTituloUsuarios);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Label labelTituloUsuarios;
        private System.Windows.Forms.Button buttonBorrarUsuarios;
        private System.Windows.Forms.Button buttonEditarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}