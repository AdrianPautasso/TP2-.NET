using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            this.OpenConnection();
            SqlCommand cmdUsuarios = new SqlCommand("select us.id_usuario, per.nombre, per.apellido, us.nombre_usuario, per.email, us.habilitado " + 
                                                    "from personas per inner join usuarios us " +
                                                    "on per.id_persona = us.id_persona " +
                                                    "order by per.nombre asc ", this.sqlConn);
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
            while (drUsuarios.Read())
            {
                Usuario usr = new Usuario();

                usr.ID = (int)drUsuarios["id_usuario"];
                usr.Nombre = (string)drUsuarios["nombre"];
                usr.Apellido = (string)drUsuarios["apellido"];
                usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                usr.EMail = (string)drUsuarios["email"];
                usr.Habilitado = (bool)drUsuarios["habilitado"];

                usuarios.Add(usr);
            }
            this.CloseConnection();
            return usuarios;
        }

        public Usuario GetOne(int id)
        {
            Usuario usr = new Usuario();
            try 
            {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("select * from usuarios where id_usuario=@id", this.sqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
                while (drUsuario.Read())
                {
                    usr.ID = (int)drUsuario["id_usuario"];
                    usr.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    usr.Clave = (string)drUsuario["clave"];
                    usr.Habilitado = (bool)drUsuario["habilitado"];
                    usr.IdPersona = (int)drUsuario["id_persona"];
                }
                this.CloseConnection();
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de usuario", ex);
                throw ExcepcionManejada;
            }
            return usr;
        }

        //SIN TRY CATCH
        public Usuario GetOne(string nombreUsuario)
        {
            Usuario usuario = new Usuario();
            this.OpenConnection();
            SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM usuarios WHERE nombre_usuario=@nombreUsuario", sqlConn);
            cmdUsuario.Parameters.Add("@nombreUsuario", SqlDbType.VarChar, 50).Value = nombreUsuario;
            SqlDataReader drUsuario = cmdUsuario.ExecuteReader();
            if (drUsuario.Read())
            {
                usuario.ID = (int)drUsuario["id_usuario"];
                usuario.NombreUsuario = (string)drUsuario["nombre_usuario"];
                usuario.Clave = (string)drUsuario["clave"];
                usuario.IdPersona = (int)drUsuario["id_persona"];
            }
            this.CloseConnection();
            return usuario;
        }

        public void Delete(int id) 
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete usuarios where id_usuario=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();                
            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar el usuario", ex);
                throw ExcepcionManejada;
            }
            finally 
            {
                this.CloseConnection();
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE usuarios "+
                                                    "SET nombre_usuario=@nombre_usuario, clave=@clave, " +
                                                         "habilitado=@habilitado, id_persona=@id_persona " +
                                                    "WHERE id_usuario=@id",sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdUpdate.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdUpdate.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdUpdate.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdUpdate.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IdPersona;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar actualizar datos del usuario", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT into usuarios (nombre_usuario, clave, habilitado, id_persona)" +
                                                      "VALUES (@nombre_usuario,@clave,@habilitado,@id_persona)" +
                                                      "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdInsert.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdInsert.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdInsert.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdInsert.Parameters.Add("@id_persona", SqlDbType.Int).Value = usuario.IdPersona;
                usuario.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar crear un usuario", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

    }
}