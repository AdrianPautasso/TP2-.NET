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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
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

        private Materia _MateriaActual;
        public Materia MateriaActual
        {
            get { return _MateriaActual; }
            set { _MateriaActual = value; }
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            MateriaActual = new MateriaLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearADatos()
        {
            switch (this.m_form)
            {
                case MateriaDesktop.ModoForm.Alta:
                    MateriaActual = new Materia();
                    MateriaActual.Descripcion = this.txtDescripcion.Text.Trim();
                    MateriaActual.HSSemanales = Convert.ToInt32(this.txtHsSemanales.Text.Trim());
                    MateriaActual.HSTotales = Convert.ToInt32(this.txtHsTotales.Text.Trim());
                    MateriaActual.IDPlan = Convert.ToInt32(this.cbxPlanes.SelectedValue);
                    MateriaActual.State = Materia.States.New;
                    break;
                case MateriaDesktop.ModoForm.Modificacion:
                    MateriaActual.Descripcion = this.txtDescripcion.Text.Trim();
                    MateriaActual.HSSemanales = Convert.ToInt32(this.txtHsSemanales.Text.Trim());
                    MateriaActual.HSTotales = Convert.ToInt32(this.txtHsTotales.Text.Trim());
                    MateriaActual.IDPlan = Convert.ToInt32(this.cbxPlanes.SelectedValue);
                    MateriaActual.State = Materia.States.Modified;
                    break;
                case MateriaDesktop.ModoForm.Baja:
                    MateriaActual.State = Materia.States.Deleted;
                    break;
                default:
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHsSemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHsTotales.Text = this.MateriaActual.HSTotales.ToString();
            this.cbxPlanes.SelectedValue = this.MateriaActual.IDPlan;
            switch (this.m_form)
            {
                case MateriaDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case MateriaDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case MateriaDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case MateriaDesktop.ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic matLog = new MateriaLogic();
            matLog.Save(MateriaActual);
        }

        public override bool Validar()
        {
            {
                string mensaje = "";

                if (String.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                    mensaje += "- La Descripcion no puede estar en blanco." + "\n";

                if (String.IsNullOrEmpty(txtHsSemanales.Text.Trim()))
                    mensaje += "- Las Horas Semanales no puede estar en blanco." + "\n";

                if (String.IsNullOrEmpty(txtHsTotales.Text.Trim()))
                    mensaje += "- Las Horas Totales no puede estar en blanco." + "\n";

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
