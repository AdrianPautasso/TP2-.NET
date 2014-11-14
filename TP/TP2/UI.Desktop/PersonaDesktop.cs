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
    public partial class PersonaDesktop : UI.Desktop.ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
            this.LlenarCbxPlanes();
            this.LlenarCbxTipos();
        }

        private void LlenarCbxTipos()
        {
            Business.Logic.TipoPersonaLogic tpl = new Business.Logic.TipoPersonaLogic();
            cbxTipoPersona.DataSource = tpl.GetAll();
            cbxTipoPersona.DisplayMember = "Descripcion";
            cbxTipoPersona.ValueMember = "ID";
        }

        private void LlenarCbxPlanes()
        {
            Business.Logic.PlanLogic plg = new Business.Logic.PlanLogic();
            cbxPlan.DataSource = plg.GetAll();
            cbxPlan.DisplayMember = "DescPlanYEspecialidad";
            cbxPlan.ValueMember = "ID";
        }

        private Persona _PersonaActual;

        public Persona PersonaActual
        {
            get { return _PersonaActual; }
            set { _PersonaActual = value; }
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public PersonaDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            PersonaActual = new PersonaLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtEmail.Text = this.PersonaActual.Email;
            this.txtTelefono.Text = this.PersonaActual.Telefono;      
            this.txtFechaNac.Text = this.PersonaActual.FechaNacimiento.ToString();
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();


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
                case UsuarioDesktop.ModoForm.Alta:
                    PersonaActual = new Persona();
                    PersonaActual.Nombre = this.txtNombre.Text;
                    PersonaActual.Apellido = this.txtApellido.Text;
                    PersonaActual.Direccion = this.txtDireccion.Text;
                    PersonaActual.Email = this.txtEmail.Text;
                    PersonaActual.Telefono = this.txtTelefono.Text;
                    PersonaActual.FechaNacimiento = Convert.ToDateTime(this.txtFechaNac.Text);
                    PersonaActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                    PersonaActual.IDTipoPersona = Convert.ToInt32(this.cbxTipoPersona.SelectedValue);
                    PersonaActual.IDPlan = Convert.ToInt32(this.cbxPlan.SelectedValue);
                    PersonaActual.State = Persona.States.New;
                    break;
                case UsuarioDesktop.ModoForm.Modificacion:
                    PersonaActual.Nombre = this.txtNombre.Text;
                    PersonaActual.Apellido = this.txtApellido.Text;
                    PersonaActual.Direccion = this.txtDireccion.Text;
                    PersonaActual.Email = this.txtEmail.Text;
                    PersonaActual.Telefono = this.txtTelefono.Text;
                    PersonaActual.FechaNacimiento = Convert.ToDateTime(this.txtFechaNac.Text);
                    PersonaActual.Legajo = Convert.ToInt32(this.txtLegajo.Text);
                    PersonaActual.IDTipoPersona = Convert.ToInt32(this.cbxTipoPersona.SelectedValue);
                    PersonaActual.IDPlan = Convert.ToInt32(this.cbxPlan.SelectedValue);
                    PersonaActual.State = Usuario.States.Modified;
                    break;
                case UsuarioDesktop.ModoForm.Baja:
                    PersonaActual.State = Usuario.States.Deleted;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PersonaLogic PerLog = new PersonaLogic();
            PerLog.Save(PersonaActual);
        }

        public override bool Validar()
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                mensaje += "- El Nombre no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtApellido.Text.Trim()))
                mensaje += "- El Apellido no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtDireccion.Text.Trim()))
                mensaje += "- La Dirección no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                mensaje += "- El Email no puede estar en blanco." + "\n";

            String expresionEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (Regex.IsMatch(txtEmail.Text, expresionEmail) == false)
                mensaje += "- El Email no es válido." + "\n";

            if (String.IsNullOrEmpty(txtTelefono.Text.Trim()))
                mensaje += "- El Teléfono no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtFechaNac.Text.Trim()))
                mensaje += "- La Fecha de nacimiento no puede estar en blanco." + "\n";

            //String expresionFecha = @"^(0?[1-9]|1[0-9]|2[0-9]|3[0-1])/(0?[1-9]|1[0-2])/(d{2}|d{4})$";

            //if (Regex.IsMatch(txtFechaNac.Text, expresionFecha) == false)
            //    mensaje += "- La fecha de nacimiento no es una fecha válida." + "\n";

            if (String.IsNullOrEmpty(txtLegajo.Text.Trim()))
                mensaje += "- El Legajo no puede estar en blanco." + "\n";

            String expresionNumeros = @"^\d+$";

            if (Regex.IsMatch(txtLegajo.Text, expresionNumeros) == false)
                mensaje += "- El Legajo debe ser solo números." + "\n";

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
