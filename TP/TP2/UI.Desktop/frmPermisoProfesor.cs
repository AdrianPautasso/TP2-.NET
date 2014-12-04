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
    public partial class frmPermisoProfesor : Form
    {
        int IDUsuario;
        int IDPersona;

        public frmPermisoProfesor(int id_usuario, int id_persona)
        {
            IDUsuario = id_usuario;
            IDPersona = id_persona;
            InitializeComponent();
        }

        private void mtsUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usrDesktop = new UsuarioDesktop(IDUsuario, ApplicationForm.ModoForm.Consulta);
            usrDesktop.Show();
        }

        private void mtsPersonas_Click(object sender, EventArgs e)
        {
            PersonaDesktop perDesktop = new PersonaDesktop(IDPersona, ApplicationForm.ModoForm.Consulta);
            perDesktop.Show();
        }

        private void mtsConsulta_Click(object sender, EventArgs e)
        {
            Cursos crs = new Cursos(IDPersona);
            crs.ShowDialog();
        }

        private void mtsInscripcion_Click(object sender, EventArgs e)
        {
            Inscripciones ins = new Inscripciones(IDPersona);
            ins.ShowDialog(); 
        }

        private void frmPermisoProfesor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

    }
}
