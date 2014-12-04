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
                Usuario usuario = new Usuario();
                foreach (var usr in this.GetAll())
                    if (usr.ID == id)
                        usuario = usr;
                return usuario;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public Usuario GetOne(string nombreUsuario)
        {
            {
                try
                {
                    Usuario usuario = new Usuario();
                    foreach (var usr in this.GetAll())
                        if (usr.NombreUsuario == nombreUsuario)
                            usuario = usr;
                    return usuario;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
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
            PersonaLogic per = new PersonaLogic();
            return per.GetOne(id_persona);
        }

        public Usuario GetOneConPersona(int id_persona)
        {
            {
                try
                {
                    Usuario usuario = new Usuario();
                    foreach (var usr in this.GetAll())
                        if (usr.IdPersona == id_persona)
                            usuario = usr;
                    return usuario;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public List<Usuario> GetAll(int idPersona)
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach (var usr in this.GetAll())
                if (usr.IdPersona == idPersona)
                    usuarios.Add(usr);
            return usuarios;
        }

        public int GetTipoPersona(int idPersona)
        {
            PersonaLogic prsLogic = new PersonaLogic();
            return prsLogic.GetTipoPer(idPersona);
        }
    }
}
