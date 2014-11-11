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

        }

        //protected void editarLinkButton_Click(object sender, EventArgs e)
        //{
        //    if (this.IsEntitySelected)
        //    {
        //        this.gridActionsPanel.Visible = false;
        //        this.formPanel.Visible = true;
        //        this.formActionPanel.Visible = true;
        //        this.FormMode = FormModes.Modificacion;
        //        this.EnableForm(true);
        //        this.LoadForm(this.SelectedID);
        //    }
        //}

        //private void SaveEntity(Usuario usuario)
        //{
        //    this.Logic.Save(usuario);
        //}

        //private void LoadEntity(Usuario usuario)
        //{
        //    usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
        //    usuario.Clave = this.claveTextBox.Text;
        //    usuario.Habilitado = this.habilitadoCheckBox.Checked;
        //    usuario.IdPersona = int.Parse(this.dpdPersonas.SelectedValue);
        //}

        //protected void cancelarLinkButton_Click(object sender, EventArgs e)
        //{
        //    this.formPanel.Visible = false;
        //    this.formActionPanel.Visible = false;
        //    this.gridActionsPanel.Visible = true;
        //}

        //private void EnableForm(bool enable)
        //{
        //    this.nombreUsuarioTextBox.Enabled = enable;
        //    this.claveTextBox.Visible = enable;
        //    this.claveLabel.Visible = enable;
        //    this.repetirclaveTextBox.Visible = enable;
        //    this.repetirClaveLabel.Visible = enable;
        //}

        //protected void eliminarLinkButton_Click(object sender, EventArgs e)
        //{
        //    if (this.IsEntitySelected)
        //    {
        //        this.gridActionsPanel.Visible = false;
        //        this.formPanel.Visible = true;
        //        this.formActionPanel.Visible = true;
        //        this.FormMode = FormModes.Baja;
        //        this.EnableForm(false);
        //        this.LoadForm(this.SelectedID);
        //    }
        //}

        //private void DeleteEntity(int id)
        //{
        //    this.Logic.Delete(id);
        //}

        //protected void aceptarLinkButton_Click(object sender, EventArgs e)
        //{
        //    switch (this.FormMode)
        //    {
        //        case FormModes.Baja:
        //            this.DeleteEntity(this.SelectedID);
        //            this.LoadGrilla();
        //            this.gridActionsPanel.Visible = true;
        //            this.formActionPanel.Visible = false;
        //            break;
        //        case FormModes.Modificacion:
        //            this.Entity = new Usuario();
        //            this.Entity.ID = this.SelectedID;
        //            this.Entity.State = BusinessEntity.States.Modified;
        //            this.LoadEntity(this.Entity);
        //            this.SaveEntity(this.Entity);
        //            this.LoadGrilla();
        //            this.gridActionsPanel.Visible = true;
        //            this.formActionPanel.Visible = false;
        //            break;
        //        case FormModes.Alta:
        //            this.Entity = new Usuario();
        //            this.LoadEntity(this.Entity);
        //            this.SaveEntity(this.Entity);
        //            this.LoadGrilla();
        //            this.gridActionsPanel.Visible = true;
        //            this.formActionPanel.Visible = false;
        //            break;
        //        default:
        //            break;
        //    }

        //    this.formPanel.Visible = false;
        //}

        //protected void nuevoLinkButton_Click(object sender, EventArgs e)
        //{
        //    this.gridActionsPanel.Visible = false;
        //    this.formActionPanel.Visible = true;
        //    this.formPanel.Visible = true;
        //    this.FormMode = FormModes.Alta;
        //    this.ClearForm();
        //    this.EnableForm(true);
        //}

        //private void ClearForm()
        //{
        //    this.habilitadoCheckBox.Checked = false;
        //    this.nombreUsuarioTextBox.Text = string.Empty;
        //}
    }
}