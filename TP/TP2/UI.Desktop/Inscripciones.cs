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
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
            this.Listar();
        }

        public void Listar()
        {
            AlumnosInscripcionesLogic alinsLogic = new AlumnosInscripcionesLogic();
            this.dgvInscripciones.DataSource = alinsLogic.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
