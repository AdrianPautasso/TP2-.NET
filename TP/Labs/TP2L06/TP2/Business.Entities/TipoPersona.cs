using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class TipoPersona
    {
        private string _descripcion;
        private int _idTipoPersona;

        public String Descripcion
        {
            get
            {
                return _descripcion;
            }
            set
            {
                _descripcion = value;
            }
        }

        public int IDTipoPersona
        {
            get
            {
                return _idTipoPersona;
            }
            set
            {
                _idTipoPersona = value;
            }
        }
    }
}
