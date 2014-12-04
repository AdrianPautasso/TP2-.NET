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
    public partial class Especialidades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrilla();
            }
        }

        EspecialidadLogic _logic;

        private EspecialidadLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new EspecialidadLogic();
                }
                return _logic;
            }
        }

        private void LoadGrilla()
        {
            this.GridViewEsp.DataSource = this.Logic.GetAll();
            this.GridViewEsp.DataBind();
        }

        private Especialidad Entity
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
            this.SelectedID = (int)this.GridViewEsp.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtDesc.Text = this.Entity.Descripcion;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.gridActionPanelEsp.Visible = false;
                this.formPanelEsp.Visible = true;
                this.formActionPanelEsp.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
            }
        }

        private void SaveEntity(Especialidad especialidad)
        {
            this.Logic.Save(especialidad);
        }

        private void LoadEntity(Especialidad especialidad)
        {
            especialidad.Descripcion = this.txtDesc.Text;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelEsp.Visible = false;
            this.formActionPanelEsp.Visible = false;
            this.gridActionPanelEsp.Visible = true;
        }

        private void EnableForm(bool enable)
        {
            this.txtDesc.Enabled = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelEsp.Visible = false;
                this.formActionPanelEsp.Visible = true;
                this.gridActionPanelEsp.Visible = false;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
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
                    this.gridActionPanelEsp.Visible = true;
                    this.formActionPanelEsp.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Especialidad();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanelEsp.Visible = true;
                    this.formActionPanelEsp.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Especialidad();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanelEsp.Visible = true;
                    this.formActionPanelEsp.Visible = false;
                    break;
                default:
                    break;
            }

            this.formPanelEsp.Visible = false;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelEsp.Visible = true;
            this.gridActionPanelEsp.Visible = false;
            this.formActionPanelEsp.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.txtDesc.Text = string.Empty;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin.aspx");
        }
    }
}