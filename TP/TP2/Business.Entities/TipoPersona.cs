﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class TipoPersona : BusinessEntity
    {
        private string _descripcion;

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
    }
}
