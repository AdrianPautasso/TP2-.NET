using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Entities;
using Data.Database;
using System.Data.SqlClient;
using System.Data;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter usuarioData;

        public UsuarioLogic()
        { 
            usuarioData = new UsuarioAdapter();
        }

        public UsuarioAdapter UsuarioData
        {
            get { return usuarioData; }
            set { usuarioData = value; }
        }

        public Usuario GetOne(int id)
        {
            try
            {
                return UsuarioData.GetOne(id);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        // SIN TRY CATCH
        public Usuario GetOne(string nombreUsuario)
        {
            return UsuarioData.GetOne(nombreUsuario);
            //List<Usuario> usuarios = new List<Usuario>();
            //Usuario usuario = new Usuario();
            //usuarios = UsuarioData.GetAll();
            //foreach (var us in usuarios)
            //{
            //    if (us.NombreUsuario == nombreUsuario)
            //    {
            //        usuario = us;
            //    }
            //}
            //return usuario;
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

        public Boolean ValidarContraseña(Usuario usuario, string contraseña)
        {
            if (usuario.Clave.Equals(contraseña))
            { return true; }
            else
            { return false; }
        }

        public Persona GetPersona(int id_persona)
        { 
            PersonaAdapter per = new PersonaAdapter();
            return per.GetOne(id_persona);
        }
    }
}
