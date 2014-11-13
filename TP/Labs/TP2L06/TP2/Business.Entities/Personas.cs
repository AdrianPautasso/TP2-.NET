using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Personas : BusinessEntity
    {
        private string _apellido;

        private string _direccion;

        private string _email;

        private System.DateTime _fechaNacimiento;

        private int _idPlan;

        private int _legajo;

        private string _nombre;

        private string _telefono;
    
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
    }
}
