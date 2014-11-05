using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        int _IDUsuario;
        public int IdUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }

        }
        int _IDModulo;
        public int IdModulo
        {
           get { return _IDModulo; }
            set { _IDModulo = value; } 
        }

        bool _PermiteAlta;
        public bool PermiteAlta
        {
           get { return _PermiteAlta; }
            set { _PermiteAlta = value; } 
        }

        bool _PermiteBaja;
        public bool PermiteBaja
        {
            get { return _PermiteBaja; }
            set { _PermiteBaja = value; } 
        }

        bool _PermiteModificacion;
        public bool PermiteModificacion
        {
           get { return _PermiteModificacion; }
            set { _PermiteModificacion = value; } 
        }

        bool _PermiteConsulta;
        public bool PermiteConsulta
        {
           get { return _PermiteConsulta; }
           set { _PermiteConsulta = value; }
        }
        }
    }

