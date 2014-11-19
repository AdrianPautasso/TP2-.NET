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

        private string _nombreAlumno;

        private string _apellidoAlumno;

        private int _legajoAlumno;

        private string _descripcionMateria;

        private string _descripcionComision;


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

        public string NombreAlumno
        {
            get { return _nombreAlumno; }
            set { _nombreAlumno = value; }
        }

        public string ApellidoAlumno
        {
            get { return _apellidoAlumno; }
            set { _apellidoAlumno = value; }
        }

        public int LegajoAlumno
        {
            get { return _legajoAlumno; }
            set { _legajoAlumno = value; }
        }

        public string DescMateria
        {
            get { return _descripcionMateria; }
            set { _descripcionMateria = value; }
        }

        public string DescComision
        {
            get { return _descripcionComision; }
            set { _descripcionComision = value; }
        }

    }
}
