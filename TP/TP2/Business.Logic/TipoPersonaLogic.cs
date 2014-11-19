using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;
using System.Data.SqlClient;
using System.Data;

namespace Business.Logic
{
    public class TipoPersonaLogic:BusinessLogic
    {
        private Data.Database.TipoPersonaAdapter tipoPersonaData;

        public TipoPersonaLogic()
        {
            tipoPersonaData = new TipoPersonaAdapter();
        }

        public Data.Database.TipoPersonaAdapter TipoPersonaData
        {
            get { return tipoPersonaData; }
            set { tipoPersonaData = value; }
        }

        public List<TipoPersona> GetAll()
        {
            return tipoPersonaData.GetAll();
        }

    }
}
