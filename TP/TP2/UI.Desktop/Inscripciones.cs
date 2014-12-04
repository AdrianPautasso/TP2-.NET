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
    public partial class Inscripciones : Form
    {
        private int idPersona;

        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
        }

        public Inscripciones(int id_persona) : this()
        {
            idPersona = id_persona;
        }

        public void Listar()
        {
            AlumnosInscripcionesLogic alinsLogic = new AlumnosInscripcionesLogic();
            PersonaLogic prsLogic = new PersonaLogic();
            Persona prs = new Persona();
            prs = prsLogic.GetOne(idPersona);
            if (prs.IDTipoPersona != 0)
            {
                switch (prs.IDTipoPersona)
                {
                    case 1:
                        this.tscEditar.Enabled = false;
                        //Todas las inscripciones del alumno
                        this.dgvInscripciones.DataSource = alinsLogic.GetAll(idPersona);
                        break;
                    case 2:
                        this.tscNueva.Enabled = false;
                        this.tscEliminar.Enabled = false;
                        //Todas las inscripciones en donde el docente este al frente del curso
                        this.dgvInscripciones.DataSource = alinsLogic.GetInscriptosCursosDocente(idPersona);
                        break;
                    case 3:
                        //Todas las inscripciones
                        this.dgvInscripciones.DataSource = alinsLogic.GetAll();
                        break;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tscNueva_Click(object sender, EventArgs e)
        {
            InscripcionesDesktop formInscripcion = new InscripcionesDesktop(ApplicationForm.ModoForm.Alta, idPersona);
            formInscripcion.ShowDialog();
            this.Listar();
        }

        private void tscEditar_Click(object sender, EventArgs e)
        {
            //try
            //{
                int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                InscripcionesDesktop formInscripcion = new InscripcionesDesktop(ID, ApplicationForm.ModoForm.Modificacion, idPersona);
                formInscripcion.ShowDialog();
                this.Listar();
            //}
            //catch (Exception ExcepcionManejada)
            //{
            //    System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            //}
        }

        private void tscEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            InscripcionesDesktop formInscripcion = new InscripcionesDesktop(ID, ApplicationForm.ModoForm.Baja, idPersona);
            formInscripcion.ShowDialog();
            this.Listar();
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
