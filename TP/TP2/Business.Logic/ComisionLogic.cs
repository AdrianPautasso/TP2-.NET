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
        private ComisionAdapter _ComisionData;
        public ComisionAdapter ComisionData
        {
            get { return _ComisionData; }
            set { _ComisionData = value; }
        }

        public ComisionLogic()
        {
            _ComisionData = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public Comision GetOne(int id)
        {
            try
            {
                Comision comision = new Comision();
                foreach (var com in ComisionData.GetAll())
                    if (com.ID == id)
                        comision = com;
                return comision;
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
