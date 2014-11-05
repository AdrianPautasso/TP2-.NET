using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Usuario : BusinessEntity 
    {
        string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        string _EMail;
        public string EMail
        {
            get { return _EMail; }
            set { _EMail = value; }
        }

        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        bool _Habilitado;
        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        string _NombreUsuario;
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        private int _IdPersona;
        public int IdPersona
        {
            get { return _IdPersona; }
            set { _IdPersona = value; }
        }

    }
}
