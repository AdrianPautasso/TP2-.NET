using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Planes.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void lnkUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios.aspx");
        }

        protected void lnkAlumInsc_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Alumnoinscripcion.aspx");
        }

        protected void lnkPersonas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas.aspx");
        }
    }
}