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
    public partial class Comision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrilla();
            }
        }

        ComisionLogic _logic;

        private ComisionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionLogic();
                }
                return _logic;
            }
        }

        private void LoadGrilla()
        {
            this.GridViewCom.DataSource = this.Logic.GetAll();
            this.GridViewCom.DataBind();
        }

        private Business.Entities.Comision Entity
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
            this.SelectedID = (int)this.GridViewCom.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelCom.Visible = true;
                this.formActionPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            //this.txtID.Text = Convert.ToString(Entity.ID);
            this.txtDesc.Text = this.Entity.Descripcion;
            this.txtAnioDesc.Text = Convert.ToString(Entity.AnioEspecialidad);
            this.txtIdPlan.Text = Convert.ToString(Entity.IDPlan);

        }

        private void EnableForm(bool enable)
        {
            this.txtDesc.Enabled = enable;
            this.txtAnioDesc.Visible = enable;
            this.txtIdPlan.Visible = enable;
            this.txtID.Visible = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelCom.Visible = true;
                this.formActionPanel.Visible = true;
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
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Business.Entities.Comision();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Comision();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    break;
                default:
                    break;
            }

            this.formPanelCom.Visible = false;
        }

        private void LoadEntity(Business.Entities.Comision comision)
        {
            comision.Descripcion = this.txtDesc.Text;
            comision.AnioEspecialidad = int.Parse(this.txtAnioDesc.Text);
            comision.IDPlan = int.Parse(this.txtIdPlan.Text);
            //comision.ID = int.Parse(this.txtID.Text);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelCom.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.txtDesc.Text = string.Empty;
            this.txtAnioDesc.Text = string.Empty;
            this.txtIdPlan.Text = string.Empty;
        }

        private void SaveEntity(Business.Entities.Comision comision)
        {
            this.Logic.Save(comision);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelCom.Visible = false;
            this.formActionPanel.Visible = false;
        }


    }
        
}