using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios.aspx");
        }

        protected void lnkComisiones_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Comisiones.aspx");
        }

        protected void lnkCursos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cursos.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void lnkPlanes_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Planes.aspx");
        }

        protected void lnkEspecialidades_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Especialidades.aspx");
        }

        protected void lnkPersonas_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas.aspx");
        }

        protected void lnkMaterias_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Materias.aspx");
        }

        protected void lnkAlumInsc_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Alumnoinscripcion.aspx");
        }

        protected void lnkDocCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DocenteCurso.aspx");
        }

        protected void lnkReporte1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReportCursos.aspx");
        }

        protected void lnkReporte2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/ReportPlanes.aspx");
        }

    }
}