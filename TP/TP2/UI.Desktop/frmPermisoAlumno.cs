using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class frmPermisoAlumno : Form
    {

        int id_persona;
        int id_usuario;

        public frmPermisoAlumno(int idUsuario, int idPersona)
        {
            id_persona = idPersona;
            id_usuario = idUsuario;
            InitializeComponent();
        }

        private void mtsPersona_Click(object sender, EventArgs e)
        {
            PersonaDesktop perDesktop = new PersonaDesktop(id_persona, ApplicationForm.ModoForm.Consulta);
            perDesktop.Show();
        }

        private void mstUsuario_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usrDesktop = new UsuarioDesktop(id_usuario, ApplicationForm.ModoForm.Consulta);
            usrDesktop.Show();
        }

        private void mstDatosAcademicos_Click(object sender, EventArgs e)
        {
            Inscripciones insDesktop = new Inscripciones(id_persona);
            insDesktop.Show();
        }

        private void frmPermisoAlumno_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
