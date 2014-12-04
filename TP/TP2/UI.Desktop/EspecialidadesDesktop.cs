using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class EspecialidadesDesktop : ApplicationForm
    {
        public EspecialidadesDesktop()
        {
            InitializeComponent();
        }

        private Especialidad _EspecialidadActual;
        public Especialidad EspecialidadActual
        {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
        }

        public EspecialidadesDesktop(ModoForm modo) : this()
        {
            m_form = modo;

        }

        public EspecialidadesDesktop(int Id, ModoForm modo) : this() 
        {
            m_form = modo;
            EspecialidadActual = new EspecialidadLogic().GetOne(Id);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text= EspecialidadActual.ID.ToString();
            this.txtEspecialidad.Text = EspecialidadActual.Descripcion;
            switch (this.m_form)
            {
                case EspecialidadesDesktop.ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case EspecialidadesDesktop.ModoForm.Baja:
                    this.btnAceptar.Text = "Borrar";
                    break;
                case EspecialidadesDesktop.ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case EspecialidadesDesktop.ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {
            switch (this.m_form)
            {
                case EspecialidadesDesktop.ModoForm.Alta:
                    EspecialidadActual = new Especialidad();
                    EspecialidadActual.Descripcion = this.txtEspecialidad.Text;
                    EspecialidadActual.State = Especialidad.States.New;
                    break;
                case EspecialidadesDesktop.ModoForm.Baja:
                    EspecialidadActual.State = Especialidad.States.Deleted;
                    break;
                case EspecialidadesDesktop.ModoForm.Modificacion:
                    EspecialidadActual.Descripcion = txtEspecialidad.Text;
                    EspecialidadActual.State = Especialidad.States.Modified;
                    break;
                default:
                    break;
            } 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic espLogic = new EspecialidadLogic();
            espLogic.Save(EspecialidadActual);
        }

        public override bool Validar()
        {
            string mensaje = "";

            if (String.IsNullOrEmpty(this.txtEspecialidad.Text.Trim()))
                mensaje += "- La Especialidad no puede estar en blanco." + "\n";

            if (!String.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
