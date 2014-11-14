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
    public partial class Planes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrilla();
            }
        }

        PlanLogic _logic;

        private PlanLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PlanLogic();
                }
                return _logic;
            }
        }

        private void LoadGrilla()
        {
            this.GridViewPlanes.DataSource = this.Logic.GetAll();
            this.GridViewPlanes.DataBind();
        }

        private Plan Entity
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
            this.SelectedID = (int)this.GridViewPlanes.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelPlan.Visible = true;
                this.formActionPanel.Visible = true;
                this.gridActionPanel.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);

            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtDesc.Text = this.Entity.Descripcion;
        }

        private void EnableForm(bool enable)
        {
            this.txtDesc.Enabled = enable;
            this.dpdEspecialidad.Visible = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelPlan.Visible = false;
                this.formActionPanel.Visible = true;
                this.gridActionPanel.Visible = false;
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
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Plan();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Plan();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                default:
                    break;
            }

            this.formPanelPlan.Visible = false;
        }

        private void LoadEntity(Plan plan)
        {
            plan.Descripcion = this.txtDesc.Text;
            plan.IDEspecialidad = int.Parse(dpdEspecialidad.SelectedValue);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelPlan.Visible = true;
            this.gridActionPanel.Visible = false;
            this.formActionPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.txtDesc.Text = string.Empty;
        }

        private void SaveEntity(Plan plan)
        {
            this.Logic.Save(plan);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelPlan.Visible = false;
            this.formActionPanel.Visible = false;
            this.gridActionPanel.Visible = true;
        }

    }
}