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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
            LlenarCbxPlanes();
        }

        private void LlenarCbxPlanes()
        {
            PlanLogic planLogic = new PlanLogic();
            cbxPlanes.DataSource = planLogic.GetAll();
            cbxPlanes.DisplayMember = "DescPlanYEspecialidad";
            cbxPlanes.ValueMember = "ID";
        }

        private Comision _comisionActual;
        public Comision ComisionActual
        {
            get { return _comisionActual; }
            set { _comisionActual = value; }
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            ComisionActual = new ComisionLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAnioEspecialidad.Text = ComisionActual.AnioEspecialidad.ToString();
            switch (this.m_form)
            {
                case ComisionDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ComisionDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case ComisionDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ComisionDesktop.ModoForm.Consulta:
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
                case ComisionDesktop.ModoForm.Alta:
                    ComisionActual = new Comision();
                    ComisionActual.Descripcion = this.txtDescripcion.Text.Trim();
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text.Trim());
                    ComisionActual.IDPlan = Convert.ToInt32(this.cbxPlanes.SelectedValue);
                    ComisionActual.State = Comision.States.New;
                    break;
                case ComisionDesktop.ModoForm.Modificacion:
                    ComisionActual.Descripcion = this.txtDescripcion.Text.Trim();
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(this.txtAnioEspecialidad.Text.Trim());
                    ComisionActual.IDPlan = Convert.ToInt32(this.cbxPlanes.SelectedValue);
                    ComisionActual.State = Comision.States.Modified;
                    break;
                case ComisionDesktop.ModoForm.Baja:
                    ComisionActual.State = Comision.States.Deleted;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic comLog = new ComisionLogic();
            comLog.Save(ComisionActual);
        }

        public override bool Validar()
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                mensaje += "- La Descripcion no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtAnioEspecialidad.Text.Trim()))
                mensaje += "- El Año de la Especialidad no puede estar en blanco." + "\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

    }
}
