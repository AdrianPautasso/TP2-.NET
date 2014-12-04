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
        int id_persona = 0;

        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AutoGenerateColumns = false;
        }

        public Cursos(int id) : this()
        {
            id_persona = id;
        }

        private void Listar()
        {
            CursoLogic cl = new CursoLogic();
            if (id_persona != 0)
            {
                this.tsbEditar.Enabled = false;
                this.tsbEliminar.Enabled = false;
                this.tsbNuevo.Enabled = false;
                dgvCursos.DataSource = cl.GetCursosDocente(id_persona);
            }
            else
            {
                dgvCursos.DataSource = cl.GetAll();
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

        private void Cursos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
