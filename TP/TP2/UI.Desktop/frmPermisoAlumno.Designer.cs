namespace UI.Desktop
{
    partial class frmPermisoAlumno
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mstDatosPersonales = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.mstUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mstDatosAcademicos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstDatosPersonales,
            this.mstDatosAcademicos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menú";
            // 
            // mstDatosPersonales
            // 
            this.mstDatosPersonales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsPersona,
            this.mstUsuario});
            this.mstDatosPersonales.Name = "mstDatosPersonales";
            this.mstDatosPersonales.Size = new System.Drawing.Size(108, 20);
            this.mstDatosPersonales.Text = "Datos Personales";
            // 
            // mtsPersona
            // 
            this.mtsPersona.Name = "mtsPersona";
            this.mtsPersona.Size = new System.Drawing.Size(133, 22);
            this.mtsPersona.Text = "De Persona";
            this.mtsPersona.Click += new System.EventHandler(this.mtsPersona_Click);
            // 
            // mstUsuario
            // 
            this.mstUsuario.Name = "mstUsuario";
            this.mstUsuario.Size = new System.Drawing.Size(133, 22);
            this.mstUsuario.Text = "De Usuario";
            this.mstUsuario.Click += new System.EventHandler(this.mstUsuario_Click);
            // 
            // mstDatosAcademicos
            // 
            this.mstDatosAcademicos.Name = "mstDatosAcademicos";
            this.mstDatosAcademicos.Size = new System.Drawing.Size(117, 20);
            this.mstDatosAcademicos.Text = "Datos Académicos";
            this.mstDatosAcademicos.Click += new System.EventHandler(this.mstDatosAcademicos_Click);
            // 
            // frmPermisoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPermisoAlumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.frmPermisoAlumno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mstDatosPersonales;
        private System.Windows.Forms.ToolStripMenuItem mtsPersona;
        private System.Windows.Forms.ToolStripMenuItem mstUsuario;
        private System.Windows.Forms.ToolStripMenuItem mstDatosAcademicos;

    }
}