namespace UI.Desktop
{
    partial class frmPermisoAdministrador
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
            this.consultarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAdministradores = new System.Windows.Forms.ToolStripMenuItem();
            this.mstAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.mstCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.mstDocentesCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mstEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mstInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mstPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.mstUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarDatosToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarDatosToolStripMenuItem
            // 
            this.consultarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstAdministradores,
            this.mstAlumnos,
            this.mstComisiones,
            this.mstCursos,
            this.mstDocentes,
            this.mstDocentesCursos,
            this.mstEspecialidades,
            this.mstInscripciones,
            this.mstMaterias,
            this.mstPlanes,
            this.mstUsuarios});
            this.consultarDatosToolStripMenuItem.Name = "consultarDatosToolStripMenuItem";
            this.consultarDatosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.consultarDatosToolStripMenuItem.Text = "Consultar Datos";
            // 
            // mstAdministradores
            // 
            this.mstAdministradores.Name = "mstAdministradores";
            this.mstAdministradores.Size = new System.Drawing.Size(164, 22);
            this.mstAdministradores.Text = "Administradores";
            this.mstAdministradores.Click += new System.EventHandler(this.mstAdministradores_Click);
            // 
            // mstAlumnos
            // 
            this.mstAlumnos.Name = "mstAlumnos";
            this.mstAlumnos.Size = new System.Drawing.Size(164, 22);
            this.mstAlumnos.Text = "Alumnos";
            this.mstAlumnos.Click += new System.EventHandler(this.mstAlumnos_Click);
            // 
            // mstComisiones
            // 
            this.mstComisiones.Name = "mstComisiones";
            this.mstComisiones.Size = new System.Drawing.Size(164, 22);
            this.mstComisiones.Text = "Comisiones";
            this.mstComisiones.Click += new System.EventHandler(this.mstComisiones_Click);
            // 
            // mstCursos
            // 
            this.mstCursos.Name = "mstCursos";
            this.mstCursos.Size = new System.Drawing.Size(164, 22);
            this.mstCursos.Text = "Cursos";
            this.mstCursos.Click += new System.EventHandler(this.mstCursos_Click);
            // 
            // mstDocentes
            // 
            this.mstDocentes.Name = "mstDocentes";
            this.mstDocentes.Size = new System.Drawing.Size(164, 22);
            this.mstDocentes.Text = "Docentes";
            this.mstDocentes.Click += new System.EventHandler(this.mstDocentes_Click);
            // 
            // mstDocentesCursos
            // 
            this.mstDocentesCursos.Name = "mstDocentesCursos";
            this.mstDocentesCursos.Size = new System.Drawing.Size(164, 22);
            this.mstDocentesCursos.Text = "Docentes_Cursos";
            this.mstDocentesCursos.Click += new System.EventHandler(this.mstDocentesCursos_Click);
            // 
            // mstEspecialidades
            // 
            this.mstEspecialidades.Name = "mstEspecialidades";
            this.mstEspecialidades.Size = new System.Drawing.Size(164, 22);
            this.mstEspecialidades.Text = "Especialidades";
            this.mstEspecialidades.Click += new System.EventHandler(this.mstEspecialidades_Click);
            // 
            // mstInscripciones
            // 
            this.mstInscripciones.Name = "mstInscripciones";
            this.mstInscripciones.Size = new System.Drawing.Size(164, 22);
            this.mstInscripciones.Text = "Inscripciones";
            this.mstInscripciones.Click += new System.EventHandler(this.mstInscripciones_Click);
            // 
            // mstMaterias
            // 
            this.mstMaterias.Name = "mstMaterias";
            this.mstMaterias.Size = new System.Drawing.Size(164, 22);
            this.mstMaterias.Text = "Materias";
            this.mstMaterias.Click += new System.EventHandler(this.mstMaterias_Click);
            // 
            // mstPlanes
            // 
            this.mstPlanes.Name = "mstPlanes";
            this.mstPlanes.Size = new System.Drawing.Size(164, 22);
            this.mstPlanes.Text = "Planes";
            this.mstPlanes.Click += new System.EventHandler(this.mstPlanes_Click);
            // 
            // mstUsuarios
            // 
            this.mstUsuarios.Name = "mstUsuarios";
            this.mstUsuarios.Size = new System.Drawing.Size(164, 22);
            this.mstUsuarios.Text = "Usuarios";
            this.mstUsuarios.Click += new System.EventHandler(this.mstUsuarios_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmPermisoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPermisoAdministrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.frmPermisoAdministrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstAlumnos;
        private System.Windows.Forms.ToolStripMenuItem mstComisiones;
        private System.Windows.Forms.ToolStripMenuItem mstCursos;
        private System.Windows.Forms.ToolStripMenuItem mstDocentes;
        private System.Windows.Forms.ToolStripMenuItem mstDocentesCursos;
        private System.Windows.Forms.ToolStripMenuItem mstEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mstInscripciones;
        private System.Windows.Forms.ToolStripMenuItem mstMaterias;
        private System.Windows.Forms.ToolStripMenuItem mstPlanes;
        private System.Windows.Forms.ToolStripMenuItem mstUsuarios;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstAdministradores;
    }
}