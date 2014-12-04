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
    public partial class UsuarioDesktop : UI.Desktop.ApplicationForm
    {
        public UsuarioDesktop()
        {
            InitializeComponent();
            this.LlenarCbxPersonas();
        }

        public void LlenarCbxPersonas()
        {
            Business.Logic.PersonaLogic pl = new Business.Logic.PersonaLogic();
            cbxPersona.DataSource = pl.GetAll();
            cbxPersona.DisplayMember = "NombreCompleto";
            cbxPersona.ValueMember = "ID";
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            m_form = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            m_form = modo;
            UsuarioActual = new UsuarioLogic().GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            this.cbxPersona.SelectedValue = this.UsuarioActual.IdPersona;
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
                    this.cbxPersona.Enabled = false;    
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
                    UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    UsuarioActual.Clave = this.txtClave.Text;
                    UsuarioActual.IdPersona = Convert.ToInt32(this.cbxPersona.SelectedValue);
                    UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    UsuarioActual.State = Usuario.States.New;
                    break;
                case UsuarioDesktop.ModoForm.Modificacion:
                    UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    UsuarioActual.Clave = this.txtClave.Text;
                    UsuarioActual.IdPersona = Convert.ToInt32(this.cbxPersona.SelectedValue);
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

        public override bool Validar() 
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
                mensaje += "- El Nombre de Usuario no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtClave.Text.Trim()))
                mensaje += "- La Clave no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtConfirmarClave.Text.Trim()))
                mensaje += "- La Confirmación de la Clave no puede estar en blanco." + "\n";

            if (txtClave.Text != txtConfirmarClave.Text)
                mensaje += "- Las Claves no coindicen." + "\n";

            if (txtClave.Text.Length < 8)
                mensaje += "- La Clave debe tener por los menos 8 caracteres." + "\n";

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