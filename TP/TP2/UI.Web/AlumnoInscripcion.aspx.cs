using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class AlumnoInscripcion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrilla();
            }
        }

        AlumnosInscripcionesLogic _logic;

        private AlumnosInscripcionesLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumnosInscripcionesLogic();
                }
                return _logic;
            }
        }

        CursoLogic _cursoLogic;

        private CursoLogic CursoLogic
        {
            get
            {
                if (_cursoLogic == null)
                {
                    _cursoLogic = new CursoLogic();
                }
                return _cursoLogic;
            }
        }

        PersonaLogic _personaLogic;

        private PersonaLogic PersonaLogic
        {
            get
            {
                if (_personaLogic == null)
                {
                    _personaLogic = new PersonaLogic();
                }
                return _personaLogic;
            }
        }

        private void LoadGrilla()
        {
            if ((Session["TipoPersona"].ToString() == "3")) // Administrador
            {
                this.GridViewAlumInsc.DataSource = this.Logic.GetAll();
                this.GridViewAlumInsc.DataBind();
            }
            else if ((Session["TipoPersona"].ToString() == "2")) // Docente
            {
                this.GridViewAlumInsc.DataSource = this.Logic.GetInscriptosCursosDocente(Convert.ToInt32(Session["ID"]));
                this.GridViewAlumInsc.DataBind();
            }
            else // Alumno
            {
                this.GridViewAlumInsc.DataSource = this.Logic.GetAll(Convert.ToInt32(Session["ID"]));
                this.GridViewAlumInsc.DataBind();
            }
        }

        private Business.Entities.AlumnoInscripcion Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridViewAlumInsc.SelectedValue;
        }
       
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected & (Session["TipoPersona"].ToString() == "1"))
            {
                this.formPanelAlumInsc.Visible = true;
                this.formActionPanel.Visible = false;
                this.gridActionPanel.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
                this.ddlAlumno.Enabled = false;
                this.txtCondicion.Text = "Inscripto";
                this.txtCondicion.Enabled = false;
                this.txtNota.Text = "0";
                this.txtNota.Enabled = false;      
            }
            else if (this.IsEntitySelected & (Session["TipoPersona"].ToString() == "2"))
            {
                this.formPanelAlumInsc.Visible = true;
                this.formActionPanel.Visible = false;
                this.gridActionPanel.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
                this.ddlAlumno.Enabled = false;
                this.ddlCurso.Enabled = false;
            }
                
            else
            {
                this.formPanelAlumInsc.Visible = true;
                this.formActionPanel.Visible = false;
                this.gridActionPanel.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);

            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtCondicion.Text = this.Entity.Condicion;
            this.txtNota.Text = (Entity.Nota).ToString();
            this.ddlCurso.SelectedValue = Entity.IDCurso.ToString();
            this.ddlAlumno.SelectedValue = Entity.IDAlumno.ToString(); 
        }

        private void EnableForm(bool enable)
        {
            this.txtNota.Visible = enable;
            this.txtCondicion.Visible = enable;
            this.ddlAlumno.Visible = enable;
            this.ddlCurso.Visible = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected & (Session["TipoPersona"].ToString() == "3" || Session["TipoPersona"].ToString() == "1"))
            {
                this.formPanelAlumInsc.Visible = false;
                this.formActionPanel.Visible = true;
                this.gridActionPanel.Visible = false;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }

            else
            {
                Page.Response.Write("<script>window.alert('No tienes los permisos suficientes para realizar la operacion');</script>");
            }
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //CursoLogic cur = new CursoLogic();
            switch (this.FormMode)
            {
                case FormModes.Baja:

                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;

                    Curso curso = new Curso();
                    curso = CursoLogic.GetCursoInscripcion(Convert.ToInt32(GridViewAlumInsc.SelectedRow.Cells[0].Text));
                    CursoLogic.SumarCupo(curso.ID);

                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrilla();
                    break;

                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.AlumnoInscripcion();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.AlumnoInscripcion();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    CursoLogic.RestaCupo(int.Parse(this.ddlCurso.SelectedValue));
                    break;
                default:
                    break;
            }

            this.formPanelAlumInsc.Visible = false;
        }

        private void LoadEntity(Business.Entities.AlumnoInscripcion aluInsc)
        {
            aluInsc.Condicion = this.txtCondicion.Text;
            aluInsc.Nota = int.Parse(this.txtNota.Text);
            aluInsc.IDAlumno = int.Parse(this.ddlAlumno.SelectedValue);
            aluInsc.IDCurso = int.Parse(this.ddlCurso.SelectedValue);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["TipoPersona"]) == 1)
            {
                this.formPanelAlumInsc.Visible = true;
                this.gridActionPanel.Visible = false;
                this.formActionPanel.Visible = true;
                this.ClearForm();
                this.ddlAlumno.Visible = false;
                this.txtCondicion.Text = "Inscripto";
                this.txtCondicion.Enabled = false;
                this.txtNota.Text = "0";
                this.txtNota.Enabled = false;
                this.FormMode = FormModes.Alta;
                this.EnableForm(true);
                this.formActionPanel.Visible = false;

            }
            else
            {
                this.formPanelAlumInsc.Visible = true;
                this.gridActionPanel.Visible = false;
                this.formActionPanel.Visible = true;
                this.FormMode = FormModes.Alta;
                this.ClearForm();
                this.EnableForm(true);
                this.formActionPanel.Visible = false;
       
            }
        }

        private void ClearForm()
        {
            this.txtCondicion.Text = string.Empty;
            this.txtNota.Text = string.Empty;
        }

        private void SaveEntity(Business.Entities.AlumnoInscripcion aluInsc)
        {
            this.Logic.Save(aluInsc);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelAlumInsc.Visible = false;
            this.formActionPanel.Visible = false;
            this.gridActionPanel.Visible = true;
        }

        protected void lnkVolver_Click(object sender, EventArgs e)
        {
            if (Session["TipoPersona"].ToString() == "1")
            {
                Response.Redirect("~/Alumno.aspx");
            }
            if (Session["TipoPersona"].ToString() == "2")
            {
                Response.Redirect("~/Docente.aspx");
            }
            else
            {
                Response.Redirect("~/Admin.aspx");
            }
        }

    }
}