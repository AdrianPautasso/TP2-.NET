using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PersonaDesktop : UI.Desktop.ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
            this.LlenarCbxPlanes();
            this.LlenarCbxTipos();
        }

        private void LlenarCbxTipos()
        {
            Business.Logic.TipoPersonaLogic tpl = new Business.Logic.TipoPersonaLogic();
            cbxTipoPersona.DataSource = tpl.GetAll();
            cbxTipoPersona.DisplayMember = "Descripcion";
            cbxTipoPersona.ValueMember = "IDTipoPersona";
        }

        private void LlenarCbxPlanes()
        {
            Business.Logic.PlanLogic plg = new Business.Logic.PlanLogic();
            cbxPlan.DataSource = plg.GetAll();
            cbxPlan.DisplayMember = "Descripcion";
            cbxPlan.ValueMember = "ID";
        }

    }
}
