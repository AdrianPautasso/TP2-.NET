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
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrilla();
            }
        }

        private Usuario Entity
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

        UsuarioLogic _logic;

        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        private void LoadGrilla()
        {
            if (Session["TipoPersona"].ToString() == "1" || Session["TipoPersona"].ToString() == "2")
            {
                this.gridView.DataSource = this.Logic.GetAll(Convert.ToInt32(Session["ID"]));
                this.gridView.DataBind();
            }
            else
            {
                this.gridView.DataSource = this.Logic.GetAll();
                this.gridView.DataBind();
            }

        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.txtNombreUsuario.Text = this.Entity.NombreUsuario;
            this.dpdPersonas.SelectedValue = this.Entity.IdPersona.ToString();

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected & Session["TipoPersona"].ToString() == "3")
            {
                this.gridActionsPanel.Visible = false;
                this.formPanel.Visible = true;
                this.formActionPanel.Visible = false;
                this.FormMode = FormModes.Modificacion;
                this.EnableForm(true);
                this.LoadForm(this.SelectedID);
            }
            else
            {
                Page.Response.Write("<script>window.alert('No tienes los permisos suficientes para realizar la operacion');</script>");
            }
        }

        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        private void LoadEntity(Usuario usuario)
        {
            usuario.NombreUsuario = this.txtNombreUsuario.Text;
            usuario.Clave = this.txtClave.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            usuario.IdPersona = int.Parse(this.dpdPersonas.SelectedValue);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
            this.formActionPanel.Visible = false;
            this.gridActionsPanel.Visible = true;
        }

        private void EnableForm(bool enable)
        {
            this.txtNombreUsuario.Enabled = enable;
            this.txtClave.Visible = enable;
            this.claveLabel.Visible = enable;
            this.txtRepetirClave.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected & Session["TipoPersona"].ToString() == "3")
            {
                this.formPanel.Visible = false;
                this.formActionPanel.Visible = true;
                this.gridActionsPanel.Visible = false;
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
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrilla();
                    this.gridActionsPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionsPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionsPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    this.formPanel.Visible = true;
                    break;
                default:
                    break;
            }

            this.formPanel.Visible = false;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            if (Session["TipoPersona"].ToString() == "3")
            {
                this.formPanel.Visible = true;
                this.formActionPanel.Visible = false;
                this.gridActionsPanel.Visible = false;
                this.FormMode = FormModes.Alta;
                this.ClearForm();
                this.EnableForm(true);
            }
            else
            {
                Page.Response.Write("<script>window.alert('No tienes los permisos suficientes para realizar la operacion');</script>");
            }
        }

        private void ClearForm()
        {
            this.habilitadoCheckBox.Checked = false;
            this.txtNombreUsuario.Text = string.Empty;
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