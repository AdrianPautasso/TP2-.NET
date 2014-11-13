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
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter _comisionData;

        public ComisionLogic()
        {
            _comisionData = new ComisionAdapter();
        }

        public ComisionAdapter ComisionData
        {
            get { return _comisionData; }
            set { _comisionData = value; }
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public Comision GetOne(int id)
        {
            try
            {
                return ComisionData.GetOne(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Save(Comision comision)
        {
            ComisionData.Save(comision);
        }

        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }

    }
}
