using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private int _IDCurso;
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        private int _IDDocente;
        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }

        private string _NombreDocente;
        public string NombreDocente
        {
            get { return _NombreDocente; }
            set { _NombreDocente = value; }
        }

        private string _ApellidoDocente;
        public string ApellidoDocente
        {
            get { return _ApellidoDocente; }
            set { _ApellidoDocente = value; }
        }

        private string _DescMateria;
        public string DescMateria
        {
            get { return _DescMateria; }
            set { _DescMateria = value; }
        }

        private string _DescComision;
        public string DescComision
        {
            get { return _DescComision; }
            set { _DescComision = value; }
        }

        public enum TiposCargos
        {
            Titular,
            Ayudante,
            Suplente
        }

        private TiposCargos _Cargo;
        public TiposCargos Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }

    }
}
