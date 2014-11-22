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
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();
            this.dgvDocentesCursos.AutoGenerateColumns = false;
            this.Listar();
        }

        public void Listar()
        {
            DocenteCursoLogic docCurLog = new DocenteCursoLogic();
            this.dgvDocentesCursos.DataSource = docCurLog.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNueva_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop formDocenteCurso = new DocenteCursoDesktop(ApplicationForm.ModoForm.Alta);
            formDocenteCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocenteCursoDesktop formDocenteCurso = new DocenteCursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formDocenteCurso.ShowDialog();
                this.Listar();
            }
            catch (Exception ExcepcionManejada)
            {
                System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((DocenteCurso)this.dgvDocentesCursos.SelectedRows[0].DataBoundItem).ID;
                DocenteCursoDesktop formDocenteCurso = new DocenteCursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formDocenteCurso.ShowDialog();
                this.Listar();
            }
            catch (Exception ExcepcionManejada)
            {
                System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            }
        }
    }
}
