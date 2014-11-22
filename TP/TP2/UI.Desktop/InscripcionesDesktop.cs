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
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class InscripcionesDesktop : ApplicationForm
    {
        public InscripcionesDesktop()
        {
            InitializeComponent();
            LlenarCbxAlumnos();
            LlenarCbxCursos();
        }

        private void LlenarCbxCursos()
        {
            CursoLogic cursoLogic = new CursoLogic();
            this.cbxCurso.DataSource = cursoLogic.GetConCupo();
            cbxCurso.DisplayMember = "DescMateriaYComision";
            cbxCurso.ValueMember = "ID";
        }

        private void LlenarCbxAlumnos()
        {
            PersonaLogic aluLog = new PersonaLogic();
            this.cbxAlumno.DataSource = aluLog.GetAll(1);
            this.cbxAlumno.DisplayMember = "NombreCompleto";
            this.cbxAlumno.ValueMember = "ID";
        }

        private AlumnoInscripcion _InscripcionActual;
        public AlumnoInscripcion InscripcionActual
        {
            get { return _InscripcionActual; }
            set { _InscripcionActual = value; }
        }

        public InscripcionesDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public InscripcionesDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            InscripcionActual = new AlumnosInscripcionesLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override bool Validar()
        {
            {
                string mensaje = "";

                if (String.IsNullOrEmpty(txtCondicion.Text.Trim()))
                    mensaje += "- La Condicion no puede estar en blanco." + "\n";

                if (String.IsNullOrEmpty(txtNota.Text.Trim()))
                    mensaje += "- Si no tiene Nota asignada, ingrese valor 0." + "\n";

                if (!String.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
        }

        public override void MapearADatos()
        {
            switch (this.m_form)
            {
                case InscripcionesDesktop.ModoForm.Alta:
                    InscripcionActual = new AlumnoInscripcion();
                    InscripcionActual.Condicion = this.txtCondicion.Text.Trim();
                    InscripcionActual.Nota = Convert.ToInt32(this.txtNota.Text.Trim());
                    InscripcionActual.IDCurso = Convert.ToInt32(this.cbxCurso.SelectedValue);
                    InscripcionActual.IDAlumno = Convert.ToInt32(this.cbxAlumno.SelectedValue);
                    InscripcionActual.State = Materia.States.New;
                    break;
                case InscripcionesDesktop.ModoForm.Modificacion:
                    InscripcionActual.Condicion = this.txtCondicion.Text.Trim();
                    InscripcionActual.Nota = Convert.ToInt32(this.txtNota.Text.Trim());
                    InscripcionActual.IDCurso = Convert.ToInt32(this.cbxCurso.SelectedValue);
                    InscripcionActual.IDAlumno = Convert.ToInt32(this.cbxAlumno.SelectedValue);
                    InscripcionActual.State = Materia.States.Modified;
                    break;
                case InscripcionesDesktop.ModoForm.Baja:
                    InscripcionActual.State = Materia.States.Deleted;
                    break;
                default:
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.InscripcionActual.ID.ToString();
            this.txtCondicion.Text = this.InscripcionActual.Condicion;
            this.txtNota.Text = this.InscripcionActual.Nota.ToString();
            switch (this.m_form)
            {
                case InscripcionesDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case InscripcionesDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case InscripcionesDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case InscripcionesDesktop.ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnosInscripcionesLogic insLogic = new AlumnosInscripcionesLogic();
            insLogic.Save(InscripcionActual);
            CursoLogic curLog = new CursoLogic();
            curLog.RestaCupo(Convert.ToInt32(cbxCurso.SelectedValue));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
