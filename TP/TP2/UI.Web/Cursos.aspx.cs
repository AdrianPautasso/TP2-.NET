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
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrilla();
            }
        }

        CursoLogic _logic;

        private CursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursoLogic();
                }
                return _logic;
            }
        }

        private void LoadGrilla()
        {
            this.GridViewCursos.DataSource = this.Logic.GetAll();
            this.GridViewCursos.DataBind();
        }

        private Curso Entity
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
            this.SelectedID = (int)this.GridViewCursos.SelectedValue;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelCursos.Visible = true;
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
            this.txtAnioCalendario.Text = Convert.ToString(this.Entity.AnioCalendario);
            this.txtCupo.Text = Convert.ToString(this.Entity.Cupo);
        }

        private void EnableForm(bool enable)
        {
            this.txtAnioCalendario.Enabled = enable;
            this.txtCupo.Visible = enable;
            this.dpbComisiones.Visible = enable;
            this.dpbMaterias.Visible = enable;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanelCursos.Visible = false;
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
                    this.Entity = new Curso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Curso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrilla();
                    this.gridActionPanel.Visible = true;
                    this.formActionPanel.Visible = false;
                    break;
                default:
                    break;
            }

            this.formPanelCursos.Visible = false;
        }

        private void LoadEntity(Curso curso)
        {
            curso.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
            curso.Cupo = int.Parse(this.txtCupo.Text);
            curso.IDMateria = int.Parse(this.dpbMaterias.SelectedValue);
            curso.IDComision = int.Parse(this.dpbComisiones.SelectedValue);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelCursos.Visible = true;
            this.gridActionPanel.Visible = false;
            this.formActionPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        private void ClearForm()
        {
            this.txtAnioCalendario.Text = string.Empty;
            this.txtCupo.Text = string.Empty;
        }

        private void SaveEntity(Curso curso)
        {
            this.Logic.Save(curso);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanelCursos.Visible = false;
            this.formActionPanel.Visible = false;
            this.gridActionPanel.Visible = true;
        }

    }
}