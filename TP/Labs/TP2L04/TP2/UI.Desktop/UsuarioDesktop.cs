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
    public partial class UsuarioDesktop : ApplicationForm // Cuando pongo que herede de applicationForm tira error.
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo)
            : this()
        {
            m_form = modo;
            UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
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
                    UsuarioActual = new Usuario();
                    UsuarioActual.Nombre = this.txtNombre.Text;
                    UsuarioActual.Apellido = this.txtApellido.Text;
                    UsuarioActual.EMail = this.txtEmail.Text;
                    UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    UsuarioActual.Clave = this.txtClave.Text;
                    //UsuarioActual.IdPersona = ((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;
                    UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    UsuarioActual.State = Usuario.States.New;
                    break;
                case UsuarioDesktop.ModoForm.Modificacion:
                    UsuarioActual.Nombre = this.txtNombre.Text;
                    UsuarioActual.Apellido = this.txtApellido.Text;
                    UsuarioActual.EMail = this.txtEmail.Text;
                    UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    UsuarioActual.Clave = this.txtClave.Text;
                    //UsuarioActual.IdPersona = ((Persona)this.dgvPersona.SelectedRows[0].DataBoundItem).ID;
                    UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    UsuarioActual.State = Usuario.States.Modified;
                    break;
                case UsuarioDesktop.ModoForm.Baja:
                    UsuarioActual.State = Usuario.States.Deleted;
                    break;
                default:
                    break;
            }
        }
        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic UsrLog = new UsuarioLogic();
            UsrLog.Save(UsuarioActual);
        }

        public virtual bool Validar() 
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                mensaje += "- El Nombre no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtApellido.Text.Trim()))
                mensaje += "- El Apellido no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtEmail.Text.Trim()))
                mensaje += "- El Email no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
                mensaje += "- El Nombre de Usuario no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtClave.Text.Trim()))
                mensaje += "- La Clave no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtConfirmarClave.Text.Trim()))
                mensaje += "- La Confirmacion de la Clave no puede estar en blanco." + "\n";

            if (txtClave.Text != txtConfirmarClave.Text)
                mensaje += "- Las claves no coindicen." + "\n";

            if (txtClave.Text.Length < 8)
                mensaje += "- La Clave debe tener por los menos 8 caracteres." + "\n";

            String expresion = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (Regex.IsMatch(txtEmail.Text, expresion) == false)
                mensaje += "- El Email no es valido." + "\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }    

            return true; 
          
        }

        private Usuario _UsuarioActual;
        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
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