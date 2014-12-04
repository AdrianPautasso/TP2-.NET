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

        public InscripcionesDesktop(ModoForm modo, int idPer)
            : this() 
        {
            this.Mform = modo;
            this.btnAceptar.Text = "Guardar";
            PersonaLogic prsLogic = new PersonaLogic();
            switch (prsLogic.GetTipoPer(idPer))
            { 
                case 1: //Si es alumno
                    CursoLogic crsLogic = new CursoLogic();
                    if (crsLogic.GetConCupo().Count == 0)
                    {
                        NoHayCursos();
                    }
                    else 
                    {
                        this.txtID.Text = idPer.ToString();
                        LlenarCbxCursos();
                        this.cbxAlumno.SelectedValue = idPer;
                        this.cbxAlumno.Enabled = false;
                        this.txtCondicion.Text = "Inscripto";
                        this.txtNota.Enabled = false;
                        this.txtNota.Text = "0";
                        this.txtCondicion.Enabled = false;
                    }
                    break;
                case 3: //Si es administrador
                    this.txtCondicion.Text = "Inscripto";
                    this.txtNota.Text = "0";
                    this.txtCondicion.Enabled = false;
                    this.txtNota.Enabled = false;
                    break;
            }
        }

        private AlumnoInscripcion _InscripcionActual;
        //private int ID;
        //private ModoForm modoForm;
        //private int IdPersona;
        public AlumnoInscripcion InscripcionActual
        {
            get { return _InscripcionActual; }
            set { _InscripcionActual = value; }
        }

        public InscripcionesDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public InscripcionesDesktop(int ID, ModoForm modoForm, int IdPer) : this()
        {
            m_form = modoForm;
            InscripcionActual = new AlumnosInscripcionesLogic().GetOne(ID);
            MapearDeDatos();


            PersonaLogic perLog = new PersonaLogic();
            Persona alumno = new Persona();
            alumno = perLog.GetAlumnoInscripcion(ID);
            this.cbxAlumno.SelectedValue = alumno.ID;

            CursoLogic crLogic = new CursoLogic();
            Curso curso = new Curso();
            curso = crLogic.GetCursoInscripcion(ID);
            this.cbxCurso.SelectedValue = curso.ID;

            this.cbxAlumno.Enabled = false;
            this.cbxCurso.Enabled = false;


            if (m_form == ModoForm.Baja) //Si es una baja
            {
                this.cbxAlumno.Enabled = false;
                this.cbxCurso.Enabled = false;
                this.txtID.Enabled=false;
                this.txtCondicion.Enabled=false;
                this.txtNota.Enabled=false;
            }
        }

        private void NoHayCursos()
        {
            this.lblID.Text = "No hay cursos disponibles";
            this.lblAlumno.Visible = false;
            this.lblNota.Visible = false;
            this.lblCondicion.Visible = false;
            this.lblCurso.Visible = false;
            this.txtID.Visible = false;
            this.txtNota.Visible = false;
            this.txtCondicion.Visible = false;
            this.cbxCurso.Visible = false;
            this.cbxAlumno.Visible = false;
            this.btnAceptar.Visible = false;
        }

        public override bool Validar()
        {
            {
                string mensaje = "";

                if (String.IsNullOrEmpty(txtCondicion.Text.Trim()))
                    mensaje += "- La Condicion no puede estar en blanco." + "\n";

                if (Convert.ToInt32(this.txtNota.Text) > 10 || Convert.ToInt32(this.txtNota.Text) < 0)
                {
                    mensaje += "- La Nota debe ser un valor entre 0 y 10." + "\n";
                }

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
            CursoLogic curLog = new CursoLogic();
            switch (this.m_form)
            {
                case InscripcionesDesktop.ModoForm.Alta:
                    InscripcionActual = new AlumnoInscripcion();
                    InscripcionActual.Condicion = this.txtCondicion.Text.Trim();
                    InscripcionActual.Nota = Convert.ToInt32(this.txtNota.Text.Trim());
                    InscripcionActual.IDCurso = Convert.ToInt32(this.cbxCurso.SelectedValue);
                    InscripcionActual.IDAlumno = Convert.ToInt32(this.cbxAlumno.SelectedValue);
                    curLog.RestaCupo(Convert.ToInt32(cbxCurso.SelectedValue));
                    InscripcionActual.State = AlumnoInscripcion.States.New;
                    break;
                case InscripcionesDesktop.ModoForm.Modificacion:
                    InscripcionActual.Condicion = this.txtCondicion.Text.Trim();
                    InscripcionActual.Nota = Convert.ToInt32(this.txtNota.Text.Trim());
                    InscripcionActual.IDCurso = Convert.ToInt32(this.cbxCurso.SelectedValue);
                    InscripcionActual.IDAlumno = Convert.ToInt32(this.cbxAlumno.SelectedValue);
                    InscripcionActual.State = AlumnoInscripcion.States.Modified;
                    break;
                case InscripcionesDesktop.ModoForm.Baja:
                    curLog.SumarCupo(Convert.ToInt32(cbxCurso.SelectedValue));
                    InscripcionActual.State = AlumnoInscripcion.States.Deleted;
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
