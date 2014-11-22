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
            List<Curso> Cursos = new List<Curso>();
            List<Curso> CursosConCupo = new List<Curso>();
            Cursos = CursoData.GetAll();
            foreach (var curso in Cursos)
            {
                if ((curso.AnioCalendario == 2014) && (curso.Cupo > 0))
                {
                    CursosConCupo.Add(curso);
                }
            }
            return CursosConCupo;
        }

        public void RestaCupo(int idCurso)
        {
            Curso curso = new Curso();
            curso = CursoData.GetOne(idCurso);
            curso.Cupo = curso.Cupo - 1;
            CursoData.Update(curso);
        }

        public Curso GetOne(int id)
        {
            return CursoData.GetOne(id);
        }

        public void Save(Curso curso)
        {
            CursoData.Save(curso);
        }

        public void Delete(int id)
        {
            CursoData.Delete(id);
        }
    }
}
