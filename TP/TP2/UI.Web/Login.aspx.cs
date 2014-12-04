using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
                Usuario usuario = new Usuario();
                usuario =  usuarioLogic.GetOne(this.txtUsuario.Text.Trim());
                if (usuario.NombreUsuario != null)
                {
                    if (usuarioLogic.ValidarContraseña(usuario, txtPass.Text.Trim()))
                    {
                        PersonaLogic perLog = new PersonaLogic();
                        Session["TipoPersona"] = perLog.GetTipoPer(usuario.IdPersona);
                        Session["ID"] = usuario.IdPersona;
                        Persona persona = new Persona();
                        persona = usuarioLogic.GetPersona(usuario.IdPersona);
                        switch (persona.IDTipoPersona)
                        { 
                            case 1:
                                Response.Redirect("~/Alumno.aspx");
                                break;
                            case 2:
                                Response.Redirect("~/Docente.aspx");
                                break;
                            case 3:
                                Response.Redirect("~/Admin.aspx");
                                break;
                        }
                    }
                    else
                    {
                        Page.Response.Write("Usuario y/o Contraseña incorrectos");
                    }
                }   
            }
    }
}