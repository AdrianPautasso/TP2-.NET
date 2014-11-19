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
        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
            this.Listar();
        }

        public void Listar()
        {
            AlumnosInscripcionesLogic alinsLogic = new AlumnosInscripcionesLogic();
            this.dgvInscripciones.DataSource = alinsLogic.GetAll();
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
            InscripcionesDesktop formInscripcion = new InscripcionesDesktop(ApplicationForm.ModoForm.Alta);
            formInscripcion.ShowDialog();
            this.Listar();
        }

        private void tscEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                InscripcionesDesktop formInscripcion = new InscripcionesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formInscripcion.ShowDialog();
                this.Listar();
            }
            catch (Exception ExcepcionManejada)
            {
                System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            }
        }

        private void tscEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((AlumnoInscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
            InscripcionesDesktop formInscripcion = new InscripcionesDesktop(ID, ApplicationForm.ModoForm.Baja);
            formInscripcion.ShowDialog();
            this.Listar();
        }
    }
}
