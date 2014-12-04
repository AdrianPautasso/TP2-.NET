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
    public class AlumnosInscripcionesLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter _alumnoInscripcionData;
        public AlumnoInscripcionAdapter AlumnoInscripcionData
        {
            get { return _alumnoInscripcionData; }
            set { _alumnoInscripcionData = value; }
        }

        public AlumnosInscripcionesLogic()
        {
            _alumnoInscripcionData = new AlumnoInscripcionAdapter();
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscripcionData.GetAll();
        }

        public List<AlumnoInscripcion> GetAll(int idPersona)
        {
            List<AlumnoInscripcion> InscripcionesAlumno = new List<AlumnoInscripcion>();
            foreach (var inscAlumno in AlumnoInscripcionData.GetAll())
                if (inscAlumno.IDAlumno == idPersona)
                    InscripcionesAlumno.Add(inscAlumno);
            return InscripcionesAlumno;
        }

        public AlumnoInscripcion GetOne(int id)
        {
            try
            {
                AlumnoInscripcion InscripcionesAlumno = new AlumnoInscripcion();
                foreach (var inscAlumno in AlumnoInscripcionData.GetAll())
                    if (inscAlumno.ID == id)
                        InscripcionesAlumno = inscAlumno;
                return InscripcionesAlumno;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Save(AlumnoInscripcion alins)
        {
            AlumnoInscripcionData.Save(alins);
        }

        public void Delete(int id)
        {
            AlumnoInscripcionData.Delete(id);
        }

        public object GetInscriptosCursosDocente(int IdPersona)
        {
            return AlumnoInscripcionData.GetInscriptosCursosDocente(IdPersona);
        }
    }
}
