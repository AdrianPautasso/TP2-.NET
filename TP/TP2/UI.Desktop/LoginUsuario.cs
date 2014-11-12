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

        //SI EL USUARIO ES PROFESOR, LES ABRE LA GRILLA USUARIOS
        //SI EL USUARIO ES ALUMNO, LES ABRE LA GRILLA PERSONAS
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                UsuarioLogic usuarioLogic = new UsuarioLogic();
                Usuario usuario = new Usuario();
                usuario =  usuarioLogic.GetOne(this.txtUsuario.Text.Trim());
                if (usuario.NombreUsuario != null)
                {
                    if (usuarioLogic.ValidarContraseña(usuario, txtContraseña.Text.Trim()))
                    {
                        Persona persona = new Persona();
                        persona = usuarioLogic.GetPersona(usuario.IdPersona);
                        switch (persona.IDTipoPersona)
                        { 
                            case 1:
                                Personas formPersonas = new Personas();
                                formPersonas.ShowDialog();
                                break;
                            case 2:
                                Usuarios formUsuarios = new Usuarios();
                                formUsuarios.ShowDialog();
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

        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
