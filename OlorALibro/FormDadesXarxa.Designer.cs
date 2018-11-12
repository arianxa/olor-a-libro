namespace OlorALibro
{
    partial class FormDadesXarxa
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
            this.labelTituloDatosRed = new System.Windows.Forms.Label();
            this.textBoxDescripcionRed = new System.Windows.Forms.TextBox();
            this.buttonPasarAJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloDatosRed
            // 
            this.labelTituloDatosRed.AutoSize = true;
            this.labelTituloDatosRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.labelTituloDatosRed.Location = new System.Drawing.Point(204, 9);
            this.labelTituloDatosRed.Name = "labelTituloDatosRed";
            this.labelTituloDatosRed.Size = new System.Drawing.Size(442, 54);
            this.labelTituloDatosRed.TabIndex = 0;
            this.labelTituloDatosRed.Text = "DATOS DE LA RED";
            // 
            // textBoxDescripcionRed
            // 
            this.textBoxDescripcionRed.Location = new System.Drawing.Point(12, 219);
            this.textBoxDescripcionRed.Multiline = true;
            this.textBoxDescripcionRed.Name = "textBoxDescripcionRed";
            this.textBoxDescripcionRed.Size = new System.Drawing.Size(625, 289);
            this.textBoxDescripcionRed.TabIndex = 1;
            // 
            // buttonPasarAJSON
            // 
            this.buttonPasarAJSON.Location = new System.Drawing.Point(499, 184);
            this.buttonPasarAJSON.Name = "buttonPasarAJSON";
            this.buttonPasarAJSON.Size = new System.Drawing.Size(91, 23);
            this.buttonPasarAJSON.TabIndex = 2;
            this.buttonPasarAJSON.Text = "Pasar a JSON";
            this.buttonPasarAJSON.UseVisualStyleBackColor = true;
            this.buttonPasarAJSON.Click += new System.EventHandler(this.buttonPasarAJSON_Click);
            // 
            // FormDadesXarxa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 520);
            this.Controls.Add(this.buttonPasarAJSON);
            this.Controls.Add(this.textBoxDescripcionRed);
            this.Controls.Add(this.labelTituloDatosRed);
            this.Name = "FormDadesXarxa";
            this.Text = "FormDadesXarxa";
            this.Load += new System.EventHandler(this.FormDadesXarxa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloDatosRed;
        private System.Windows.Forms.TextBox textBoxDescripcionRed;
        private System.Windows.Forms.Button buttonPasarAJSON;
    }
}