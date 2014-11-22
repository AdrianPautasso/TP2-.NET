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
    public class DocenteCursoLogic : BusinessLogic
    {
        private DocenteCursoAdapter _DocenteCursoData;
        public DocenteCursoAdapter DocenteCursoData
        {
            get { return _DocenteCursoData; }
            set { _DocenteCursoData = value; }
        }

        public DocenteCursoLogic()
        {
            _DocenteCursoData = new DocenteCursoAdapter();
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }

        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoData.GetOne(id);
        }

        public void Save(DocenteCurso DocenteCursoActual)
        {
            DocenteCursoData.Save(DocenteCursoActual);
        }
    }
}
