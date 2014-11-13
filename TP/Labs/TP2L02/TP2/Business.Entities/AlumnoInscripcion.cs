using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        private string _condicion;

        private int _idAlumno;

        private int _nota;

        private int _idCurso;
        public string Condicion
        {
            get
            {
                return _condicion;
            }
            set
            {
                _condicion = value;
            }
        }
        
        public int IDAlumno
        {
            get
            {
                return _idAlumno;
            }
            set
            {
                _idAlumno = value;
            }
        }

        public int Nota
        {
            get
            {
                return _nota;
            }
            set
            {
                _nota = value;
            }
        }

        public int IDCurso
        {
            get
            {
                return _idCurso;
            }
            set
            {
                _idCurso = value;
            }
        }
    }
}
