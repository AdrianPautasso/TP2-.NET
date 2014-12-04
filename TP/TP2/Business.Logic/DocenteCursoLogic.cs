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
            DocenteCurso docCurso = new DocenteCurso();
            foreach (var dc in this.DocenteCursoData.GetAll())
                if (dc.ID == id)
                    docCurso = dc;
            return docCurso;
        }

        public void Save(DocenteCurso DocenteCursoActual)
        {
            DocenteCursoData.Save(DocenteCursoActual);
        }

        public void Delete(int id)
        {
            DocenteCursoData.Delete(id);
        }

        public List<DocenteCurso> GetAll(int idPersona)
        {
            List<DocenteCurso> cursosDocente = new List<DocenteCurso>();
            foreach (var cd in this.GetAll())
                if (cd.IDDocente == idPersona)
                    cursosDocente.Add(cd);
            return cursosDocente;
        }

    }
}
