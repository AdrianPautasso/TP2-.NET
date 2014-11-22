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

        public AlumnoInscripcion GetOne(int id)
        {
            //try
            //{
                return AlumnoInscripcionData.GetOne(id);
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
        }

        public void Save(AlumnoInscripcion alins)
        {
            AlumnoInscripcionData.Save(alins);
        }

        public void Delete(int id)
        {
            AlumnoInscripcionData.Delete(id);
        }

    }
}
