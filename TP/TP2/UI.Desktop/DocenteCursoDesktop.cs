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
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
            LlenarCbxCursos();
            LlenarCbxCargos();
            LlenarCbxDocentes();
        }

        private void LlenarCbxDocentes()
        {
            PersonaLogic perLogic = new PersonaLogic();
            cbxDocentes.DataSource = perLogic.GetAll(2);
            cbxDocentes.DisplayMember = "NombreCompleto";
            cbxDocentes.ValueMember = "ID";
        }

        private void LlenarCbxCargos()
        {
            this.cbxCargos.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargos));
        }

        private void LlenarCbxCursos()
        {
            CursoLogic cursoLogic = new CursoLogic();
            cbxCursos.DataSource = cursoLogic.GetAll();
            cbxCursos.DisplayMember = "DescMateriaYComision";
            cbxCursos.ValueMember = "ID";
        }

        private DocenteCurso _DocenteCursoActual;
        public DocenteCurso DocenteCursoActual
        {
            get { return _DocenteCursoActual; }
            set { _DocenteCursoActual = value; }
        }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public DocenteCursoDesktop(int id, ModoForm modo) : this()
        {
            m_form = modo;
            DocenteCursoActual = new DocenteCursoLogic().GetOne(id);
            MapearDeDatos();
        }

        public override void MapearADatos()
        {
            switch (this.m_form)
            { 
                case DocenteCursoDesktop.ModoForm.Alta:
                    DocenteCursoActual = new DocenteCurso();
                    DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)this.cbxCargos.SelectedValue;
                    DocenteCursoActual.IDCurso = Convert.ToInt32(cbxCursos.SelectedValue);
                    DocenteCursoActual.IDDocente = Convert.ToInt32(cbxDocentes.SelectedValue);
                    DocenteCursoActual.State = DocenteCurso.States.New;
                    break;
                case DocenteCursoDesktop.ModoForm.Baja:
                    DocenteCursoActual.State = DocenteCurso.States.Deleted;
                    break;
                case DocenteCursoDesktop.ModoForm.Modificacion:
                    DocenteCursoActual.Cargo = (DocenteCurso.TiposCargos)this.cbxCargos.SelectedValue;
                    DocenteCursoActual.IDCurso = Convert.ToInt32(cbxCursos.SelectedValue);
                    DocenteCursoActual.IDDocente = Convert.ToInt32(cbxDocentes.SelectedValue);
                    DocenteCursoActual.State = DocenteCurso.States.Modified;
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = DocenteCursoActual.ID.ToString();
            this.cbxCursos.SelectedValue = this.DocenteCursoActual.IDCurso;
            this.cbxDocentes.SelectedValue = this.DocenteCursoActual.IDDocente;
            switch (this.m_form)
            { 
                case DocenteCursoDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case DocenteCursoDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case DocenteCursoDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case DocenteCursoDesktop.ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic docenteCursoLogic = new DocenteCursoLogic();
            docenteCursoLogic.Save(DocenteCursoActual);
        }

        public override bool Validar()
        {
            {
                string mensaje = "";

                if (this.cbxDocentes.SelectedItem == null)
                    mensaje += "- Debe elegir un Docente." + "\n";

                if (this.cbxCursos.SelectedItem == null)
                    mensaje += "- Debe elegir un Curso." + "\n";

                if (this.cbxCargos.SelectedItem == null)
                    mensaje += "- Debe elegir un Cargo." + "\n";

                if (!String.IsNullOrEmpty(mensaje))
                {
                    MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
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
