using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Persona : BusinessEntity
    {
        private string _descEspecialidad;

        private string _descPlan;

        private string _descTipoPersona;

        private int _IDTipoPersona;

        private string _apellido;

        private string _direccion;

        private string _email;

        private System.DateTime _fechaNacimiento;

        private int _idPlan;

        private int _legajo;

        private string _nombre;

        private string _telefono;

        public string NombreCompleto
        {
            get 
            {
                string nombreCompleto;
                nombreCompleto = _nombre + " " + _apellido;
                return nombreCompleto;
            }
        }

        public int IDTipoPersona 
        {
            get { return _IDTipoPersona; }
            set { _IDTipoPersona = value; }
        }
    
        public String Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
            }
        }

        public String Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        public String Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public int IDPlan
        {
            get
            {
                return _idPlan;
            }
            set
            {
                _idPlan = value;
            }
        }

        public int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }

        public String Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public String Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        public string DescEspecialidad
        {
            get { return _descEspecialidad; }
            set { _descEspecialidad = value; }
        }

        public string DescPlan  
        {
            get { return _descPlan; }
            set { _descPlan = value; }
        }

        public string DescTipoPersona
        {
            get { return _descTipoPersona; }
            set { _descTipoPersona = value; }
        }
    }
}
