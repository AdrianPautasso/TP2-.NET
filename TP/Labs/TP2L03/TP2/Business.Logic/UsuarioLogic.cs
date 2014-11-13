using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter usuarioData;

        public UsuarioLogic()
        { 
            UsuarioAdapter UsuarioData = new UsuarioAdapter();
        }

        public UsuarioAdapter UsuarioData
        {
            get
            {
                return usuarioData;
            }
            set
            {
                usuarioData = value;
            }
        }

        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
             return UsuarioData.GetAll();
        }

        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }

        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
    }
}
