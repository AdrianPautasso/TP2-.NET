namespace UI.Desktop
{
    partial class frmPermisoProfesor
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
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.datosFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsInscripcion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.datosFacultadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsUsuario,
            this.mtsPersonas});
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            // 
            // mtsUsuario
            // 
            this.mtsUsuario.Name = "mtsUsuario";
            this.mtsUsuario.Size = new System.Drawing.Size(133, 22);
            this.mtsUsuario.Text = "De Usuario";
            this.mtsUsuario.Click += new System.EventHandler(this.mtsUsuario_Click);
            // 
            // mtsPersonas
            // 
            this.mtsPersonas.Name = "mtsPersonas";
            this.mtsPersonas.Size = new System.Drawing.Size(133, 22);
            this.mtsPersonas.Text = "De Persona";
            this.mtsPersonas.Click += new System.EventHandler(this.mtsPersonas_Click);
            // 
            // datosFacultadToolStripMenuItem
            // 
            this.datosFacultadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsConsulta,
            this.mtsInscripcion});
            this.datosFacultadToolStripMenuItem.Name = "datosFacultadToolStripMenuItem";
            this.datosFacultadToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.datosFacultadToolStripMenuItem.Text = "Datos Facultad";
            // 
            // mtsConsulta
            // 
            this.mtsConsulta.Name = "mtsConsulta";
            this.mtsConsulta.Size = new System.Drawing.Size(233, 22);
            this.mtsConsulta.Text = "Consultar Cursos Asignados";
            this.mtsConsulta.Click += new System.EventHandler(this.mtsConsulta_Click);
            // 
            // mtsInscripcion
            // 
            this.mtsInscripcion.Name = "mtsInscripcion";
            this.mtsInscripcion.Size = new System.Drawing.Size(233, 22);
            this.mtsInscripcion.Text = "Gestionar Inscripcion a Cursos";
            this.mtsInscripcion.Click += new System.EventHandler(this.mtsInscripcion_Click);
            // 
            // frmPermisoProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPermisoProfesor";
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.frmPermisoProfesor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsUsuario;
        private System.Windows.Forms.ToolStripMenuItem mtsPersonas;
        private System.Windows.Forms.ToolStripMenuItem datosFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtsConsulta;
        private System.Windows.Forms.ToolStripMenuItem mtsInscripcion;
    }
}