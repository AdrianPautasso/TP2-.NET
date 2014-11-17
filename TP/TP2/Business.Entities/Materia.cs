using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private string _descripcion;

        private int _hsSemanales;

        private int _idPlan;

        private int _hsTotales;

        private string _descPlan;
    
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

        public int HSSemanales
        {
            get
            {
                return _hsSemanales;
            }
            set
            {
                _hsSemanales = value;
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

        public string DescPlan
        {
            get { return _descPlan; }
            set { _descPlan = value; }
        }

        public int HSTotales
        {
            get
            {
                return _hsTotales;
            }
            set
            {
                _hsTotales = value;
            }
        }
    }
}
