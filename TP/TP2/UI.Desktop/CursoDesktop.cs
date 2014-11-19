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
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
            LlenarCbxMaterias();
            LlenarCbxComisiones();
        }

        private void LlenarCbxComisiones()
        {
            ComisionLogic comisionLogic = new ComisionLogic();
            cbxComision.DataSource = comisionLogic.GetAll();
            cbxComision.DisplayMember = "Descripcion";
            cbxComision.ValueMember = "ID";
        }

        private void LlenarCbxMaterias()
        {
            MateriaLogic materiaLogic = new MateriaLogic();
            cbxMateria.DataSource = materiaLogic.GetAll();
            cbxMateria.DisplayMember = "Descripcion";
            cbxMateria.ValueMember = "ID";
        }

        private Curso _CursoActual;
        public Curso CursoActual
        {
            get { return _CursoActual; }
            set { _CursoActual = value; }
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }
      
        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            CursoActual = new CursoLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txtAnioAcademico.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();             
            switch (this.m_form)
            {
                case UsuarioDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case UsuarioDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case UsuarioDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case UsuarioDesktop.ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {
            switch (this.m_form)
            { 
                case CursoDesktop.ModoForm.Alta:
                    CursoActual = new Curso();
                    CursoActual.IDComision = Convert.ToInt32(this.cbxComision.SelectedValue);
                    CursoActual.IDMateria = Convert.ToInt32(this.cbxMateria.SelectedValue);
                    CursoActual.AnioCalendario = Convert.ToInt32(this.txtAnioAcademico.Text);
                    CursoActual.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    CursoActual.State = Curso.States.New;
                    break;
                case CursoDesktop.ModoForm.Baja:
                    CursoActual.State = Curso.States.Deleted;
                    break;
                case CursoDesktop.ModoForm.Modificacion:
                    CursoActual.ID = Convert.ToInt32(this.txtID.Text);
                    CursoActual.IDComision = Convert.ToInt32(this.cbxComision.SelectedValue);
                    CursoActual.IDMateria = Convert.ToInt32(this.cbxMateria.SelectedValue);
                    CursoActual.AnioCalendario = Convert.ToInt32(this.txtAnioAcademico.Text);
                    CursoActual.Cupo = Convert.ToInt32(this.txtCupo.Text);
                    CursoActual.State = Curso.States.Modified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic cursoLogic = new CursoLogic();
            cursoLogic.Save(CursoActual);
        }

        public override bool Validar()
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(this.txtAnioAcademico.Text.Trim()))
                mensaje += "- El Año Académico no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(this.txtCupo.Text.Trim()))
                mensaje += "- el Cupo no puede estar en blanco." + "\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
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
