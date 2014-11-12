using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private string _descripcion;
        private int _idEspecialidad;
        private string _descEspecialidad;
    
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

        public int IDEspecialidad
        {
            get
            {
                return _idEspecialidad;
            }
            set
            {
                _idEspecialidad = value;
            }
        }

        public String DescEspecialidad
        {
            get { return _descEspecialidad; }
            set { _descEspecialidad = value; }
        }

        public String DescPlanYEspecialidad
        {
            get
            {
                string planYespecialidad = _descripcion + " " + _descEspecialidad;
                return planYespecialidad;

            }
        }
    }
}
