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
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter _especialidadData;

        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
        }

        public EspecialidadAdapter EspecialidadData
        {
            get { return _especialidadData; }
            set { _especialidadData = value; }
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int id)
        {
            try
            {
                return EspecialidadData.GetOne(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Save(Especialidad especialidad)
        {
            EspecialidadData.Save(especialidad);
        }

        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }

    }
}
