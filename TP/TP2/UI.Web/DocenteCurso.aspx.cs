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
    public partial class DocenteCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCargo.DataSource = Enum.GetNames(typeof(Business.Entities.DocenteCurso.TiposCargos));
                ddlCargo.DataBind();
                LoadGrilla(); 
            }
        }

        DocenteCursoLogic _logic;

        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new DocenteCursoLogic();
                }
                return _logic;
            }
        }

        private void LoadGrilla()
        {
            if ((Session["TipoPersona"].ToString() == "3")) // Administrador
            {
                this.GridViewDocCur.DataSource = this.Logic.GetAll();
                this.GridViewDocCur.DataBind();
            }
            else if (Session["TipoPersona"].ToString() == "2")
            {
                this.GridViewDocCur.DataSource = this.Logic.GetAll(Convert.ToInt32(Session["ID"]));
                this.GridViewDocCur.DataBind();
            }
        }

        private Business.Entities.DocenteCurso Entity
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
            this.SelectedID = (int)this.GridViewDocCur.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if ((this.IsEntitySelected) & (Session["TipoPersona"].ToString() == "3"))
            {
                this.formPanelDocCur.Visible = true;
                this.formActionPanel.Visible = false;
                this.gridActionPanel.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
            }
            else
            {
                Page.Response.Write("<script>window.alert('No tienes los permisos suficientes para realizar la operacion');</script>");
            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.ddlCurso.SelectedValue = Entity.IDCurso.ToString();
            this.ddlDocente.SelectedValue = Entity.IDDocente.ToString();
        }

        private void EnableForm(bool enable)
        {
            this.ddlDocente.Visible = enable;
            this.ddlCurso.Visible = enable;
            this.ddlCargo.Visible = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if ((this.IsEntitySelected) & (Session["TipoPersona"].ToString() == "3"))
            {
                this.formPanelDocCur.Visible = false;
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

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.DocenteCurso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.DocenteCurso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                default:
                    break;
            }

            this.formPanelDocCur.Visible = false;
        }

        private void LoadEntity(Business.Entities.DocenteCurso docCurs)
        {
            docCurs.IDDocente = int.Parse(this.ddlDocente.SelectedValue);
            docCurs.IDCurso = int.Parse(this.ddlCurso.SelectedValue);
            docCurs.Cargo = (Business.Entities.DocenteCurso.TiposCargos)Enum.Parse(typeof(Business.Entities.DocenteCurso.TiposCargos), this.ddlCargo.SelectedValue);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            if (Session["TipoPersona"].ToString() == "3")
            {
                this.formPanelDocCur.Visible = true;
                this.gridActionPanel.Visible = false;
                this.formActionPanel.Visible = true;
                this.FormMode = FormModes.Alta;
                this.EnableForm(true);
            }
            else
            {
                Page.Response.Write("<script>window.alert('No tienes los permisos suficientes para realizar la operacion');</script>");
            }
        }

        private void SaveEntity(Business.Entities.DocenteCurso docCurs)
        {
            this.Logic.Save(docCurs);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelDocCur.Visible = false;
            this.formActionPanel.Visible = false;
            this.gridActionPanel.Visible = true;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            if (Session["TipoPersona"].ToString() == "3")
            {
                Response.Redirect("~/Admin.aspx");
            }
            else if (Session["TipoPersona"].ToString() == "2")
            {
                Response.Redirect("~/Docente.aspx");
            }
        }

    }
}