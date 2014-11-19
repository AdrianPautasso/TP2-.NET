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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
            this.Listar();
        }

        private void Listar()
        {
            CursoLogic curLog = new CursoLogic();
            dgvCursos.DataSource = curLog.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formCurso.ShowDialog();
                this.Listar();
            }
            catch (Exception ExcepcionManejada)
            {
                System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            //try
            //{
                CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
                formCurso.ShowDialog();
                this.Listar();
            //}
            //catch (Exception ExcepcionManejada)
            //{
            //    System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            //}
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            //try
            //{
                int ID = ((Curso)this.dgvCursos.SelectedRows[0].DataBoundItem).ID;
                CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
                formCurso.ShowDialog();
                this.Listar();
            //}
            //catch (Exception ExcepcionManejada)
            //{
            //    System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            //}
        }
    }
}
