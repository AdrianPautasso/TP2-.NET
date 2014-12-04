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

namespace UI.Desktop
{
    public partial class Personas : Form
    {
        private int id_tipo_persona;

        public Personas()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns = false;
            //Listar();
        }

        public Personas(int idTipo)
        {
            this.id_tipo_persona = idTipo;
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns = false;
        }

        private void Listar()
        {
            if (id_tipo_persona == 1)
            {
                PersonaLogic persona = new PersonaLogic();
                this.dgvPersonas.DataSource = persona.GetAll(1);
            }
            else if (id_tipo_persona == 2)
            {
                PersonaLogic persona = new PersonaLogic();
                this.dgvPersonas.DataSource = persona.GetAll(2);
            }
            else if (id_tipo_persona == 3)
            {
                PersonaLogic persona = new PersonaLogic();
                this.dgvPersonas.DataSource = persona.GetAll(3);
            }
            else
            {
                PersonaLogic ul = new PersonaLogic();
                dgvPersonas.DataSource = ul.GetAll();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNueva_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Alta, id_tipo_persona);
            formPersona.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
                PersonaDesktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Modificacion, id_tipo_persona);
                formPersona.ShowDialog();
                this.Listar();
            }
            catch (Exception ExcepcionManejada)
            {
                System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            }

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = ((Business.Entities.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
                PersonaDesktop formPersona = new PersonaDesktop(ID, ApplicationForm.ModoForm.Baja, id_tipo_persona);
                formPersona.ShowDialog();
                this.Listar();
            }
            catch (Exception ExcepcionManejada)
            {
                System.Windows.Forms.MessageBox.Show(ExcepcionManejada.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

    }
}
