using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class frmPermisoAdministrador : Form
    {
        int IDPersona;
        
        public frmPermisoAdministrador(int idPersona)
        {
            InitializeComponent();
            IDPersona = idPersona;
        }

        private void mstAdministradores_Click(object sender, EventArgs e)
        {
            Personas per = new Personas(3);
            per.Show();
        }

        private void mstAlumnos_Click(object sender, EventArgs e)
        {
            Personas per = new Personas(1);
            per.Show();
        }

        private void mstComisiones_Click(object sender, EventArgs e)
        {
            Comisiones com = new Comisiones();
            com.Show();
        }

        private void mstCursos_Click(object sender, EventArgs e)
        {
            Cursos cur = new Cursos();
            cur.Show();
        }

        private void mstDocentes_Click(object sender, EventArgs e)
        {
            Personas per = new Personas(2);
            per.Show();
        }

        private void mstDocentesCursos_Click(object sender, EventArgs e)
        {
            DocentesCursos dc = new DocentesCursos();
            dc.Show();
        }

        private void mstEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.Show();
        }

        private void mstInscripciones_Click(object sender, EventArgs e)
        {
            Inscripciones ins = new Inscripciones(IDPersona);
            ins.Show();
        }

        private void mstMaterias_Click(object sender, EventArgs e)
        {
            Materias mat = new Materias();
            mat.Show();
        }

        private void mstPlanes_Click(object sender, EventArgs e)
        {
            Planes pl = new Planes();
            pl.Show();
        }

        private void mstUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.Show();
        }

        private void frmPermisoAdministrador_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
