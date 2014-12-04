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
    public partial class PlanDesktop : UI.Desktop.ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
            this.LlenarCbxEsp();
        }

        private void LlenarCbxEsp()
        {
            Business.Logic.EspecialidadLogic el = new Business.Logic.EspecialidadLogic();
            cbxEsp.DataSource = el.GetAll();
            cbxEsp.DisplayMember = "Descripcion";
            cbxEsp.ValueMember = "ID";
        }

        private Plan _PlanActual;

        public Plan PlanActual
        {
            get { return _PlanActual; }
            set { _PlanActual = value; }
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            PlanActual = new PlanLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDesc.Text = this.PlanActual.Descripcion;
            this.cbxEsp.SelectedValue = this.PlanActual.IDEspecialidad;
            switch (this.m_form)
            {
                case PlanDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case PlanDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case PlanDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case PlanDesktop.ModoForm.Consulta:
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
                case PlanDesktop.ModoForm.Alta:
                    PlanActual = new Plan();
                    PlanActual.Descripcion = this.txtDesc.Text;
                    PlanActual.IDEspecialidad = Convert.ToInt32(this.cbxEsp.SelectedValue);
                    PlanActual.State = Plan.States.New;
                    break;
                case PlanDesktop.ModoForm.Modificacion:
                    PlanActual.Descripcion = this.txtDesc.Text;
                    PlanActual.IDEspecialidad = Convert.ToInt32(this.cbxEsp.SelectedValue);
                    PlanActual.State = Plan.States.Modified;
                    break;
                case PlanDesktop.ModoForm.Baja:
                    PlanActual.State = Plan.States.Deleted;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic PlanLog = new PlanLogic();
            PlanLog.Save(PlanActual);
        }

        public override bool Validar()
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(txtDesc.Text.Trim()))
                mensaje += "- La descripcion no puede estar en blanco." + "\n";

            //if (String.IsNullOrEmpty(txtApellido.Text.Trim()))
            //    mensaje += "- El Apellido no puede estar en blanco." + "\n";

            //if (String.IsNullOrEmpty(txtDireccion.Text.Trim()))
            //    mensaje += "- La Dirección no puede estar en blanco." + "\n";

            //if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
            //    mensaje += "- El Email no puede estar en blanco." + "\n";

            //String expresionEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            //    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            //if (Regex.IsMatch(txtEmail.Text, expresionEmail) == false)
            //    mensaje += "- El Email no es válido." + "\n";

            //if (String.IsNullOrEmpty(txtTelefono.Text.Trim()))
            //    mensaje += "- El Teléfono no puede estar en blanco." + "\n";

            //if (String.IsNullOrEmpty(txtFechaNac.Text.Trim()))
            //    mensaje += "- La Fecha de nacimiento no puede estar en blanco." + "\n";

            //String expresionFecha = @"^(0?[1-9]|1[0-9]|2[0-9]|3[0-1])/(0?[1-9]|1[0-2])/(d{2}|d{4})$";

            //if (Regex.IsMatch(txtFechaNac.Text, expresionFecha) == false)
            //    mensaje += "- La fecha de nacimiento no es una fecha válida." + "\n";

            //if (String.IsNullOrEmpty(txtLegajo.Text.Trim()))
            //    mensaje += "- El Legajo no puede estar en blanco." + "\n";

            //String expresionNumeros = @"^\d+$";

            //if (Regex.IsMatch(txtLegajo.Text, expresionNumeros) == false)
            //    mensaje += "- El Legajo debe ser solo números." + "\n";

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
