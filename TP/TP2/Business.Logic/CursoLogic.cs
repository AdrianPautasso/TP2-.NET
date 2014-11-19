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
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter _CursoData;
        public CursoAdapter CursoData
        {
            get { return _CursoData; }
            set { _CursoData = value; }
        }

        public CursoLogic()
        {
            _CursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            return CursoData.GetAll();
        }

        public List<Curso> GetConCupo()
        {
            return CursoData.GetConCupo();
        }

        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }

        public void Save(Curso curso)
        {
            CursoData.Save(curso);
        }

        public void Update(Curso curso)
        { 
            CursoData.Update(curso);
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
    }
}
