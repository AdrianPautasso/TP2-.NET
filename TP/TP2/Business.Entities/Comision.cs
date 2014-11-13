using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _AnioEspecialidad;
        private string _Descripcion;
        private int _IDPlan;
        private string _DescPlan;
        private string _DescEspecialidad;
    
        public int AnioEspecialidad
        {
            get
            {
                return _AnioEspecialidad;
            }
            set
            {
                _AnioEspecialidad = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }

        public int IDPlan
        {
            get
            {
                return _IDPlan;
            }
            set
            {
                _IDPlan = value;
            }
        }

        public string DescPlan
        {
            get { return _DescPlan; }
            set { _DescPlan = value; }
        }

        public string DescEspecialidad 
        { 
            get { return _DescEspecialidad; }
            set { _DescEspecialidad = value; }
        }
    }
}
