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

namespace UI.Desktop
{
    public partial class LoginUsuario : Form
    {
        public LoginUsuario()
        {
            InitializeComponent();
        }

        public bool Validar()
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
                mensaje += "- El Usuario no puede estar en blanco." + "\n";

            if (String.IsNullOrEmpty(txtContraseña.Text.Trim()))
                mensaje += "- La Contraseña no puede estar en blanco." + "\n";

            if (txtContraseña.Text.Length < 8)
                mensaje += "- La Contraseña debe tener por los menos 8 caracteres." + "\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        //CREO QUE SI SACAMOS ESTO ANDA IGUAL, POR QUE ESTA PEGADO ABAJO EL MISMO CODIGO PARA QUE ANDE CUANDO INGRESAS CON ENTER
        //private void btnIngresar_Click(object sender, EventArgs e)
        //{
        //    if (Validar())
        //    {
        //        UsuarioLogic usuarioLogic = new UsuarioLogic();
        //        Usuario usuario = new Usuario();
        //        usuario = usuarioLogic.GetOne(this.txtUsuario.Text.Trim());
        //        if (usuario.NombreUsuario != null)
        //        {
        //            if (usuarioLogic.ValidarContraseña(usuario, txtContraseña.Text.Trim()))
        //            {
        //                Persona persona = new Persona();
        //                persona = usuarioLogic.GetPersona(usuario.IdPersona);
        //                switch (persona.IDTipoPersona)
        //                {
        //                    case 1:
        //                        frmPermisoAlumno formAlumno = new frmPermisoAlumno(usuario.ID, usuario.IdPersona);
        //                        formAlumno.ShowDialog();
        //                        break;
        //                    case 2:
        //                        frmPermisoProfesor formProfesor = new frmPermisoProfesor(usuario.ID, usuario.IdPersona);
        //                        formProfesor.ShowDialog();
        //                        break;
        //                    case 3:
        //                        frmPermisoAdministrador formAdministrador = new frmPermisoAdministrador(usuario.IdPersona);
        //                        formAdministrador.ShowDialog();
        //                        break;
        //                    default:
        //                        break;
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Contraseña Incorrecta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario inexistente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Validar())
                {
                    UsuarioLogic usuarioLogic = new UsuarioLogic();
                    Usuario usuario = new Usuario();
                    usuario = usuarioLogic.GetOne(this.txtUsuario.Text.Trim());
                    if (usuario.NombreUsuario != null)
                    {
                        if (usuarioLogic.ValidarContraseña(usuario, txtContraseña.Text.Trim()))
                        {
                            Persona persona = new Persona();
                            persona = usuarioLogic.GetPersona(usuario.IdPersona);
                            switch (persona.IDTipoPersona)
                            {
                                case 1:
                                    frmPermisoAlumno formAlumno = new frmPermisoAlumno(usuario.ID, usuario.IdPersona);
                                    formAlumno.ShowDialog();
                                    break;
                                case 2:
                                    frmPermisoProfesor formProfesor = new frmPermisoProfesor(usuario.ID, usuario.IdPersona);
                                    formProfesor.ShowDialog();
                                    break;
                                case 3:
                                    frmPermisoAdministrador formAdministrador = new frmPermisoAdministrador(usuario.IdPersona);
                                    formAdministrador.ShowDialog();
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
