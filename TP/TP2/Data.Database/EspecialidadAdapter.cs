using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            this.OpenConnection();
            SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", this.sqlConn);
            SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
            while (drEspecialidades.Read())
            {
                Business.Entities.Especialidad especialidad = new Especialidad();

                especialidad.ID = (int)drEspecialidades["id_especialidad"];
                especialidad.Descripcion = (string)drEspecialidades["desc_especialidad"];
                especialidades.Add(especialidad);
            }
            this.CloseConnection();
            return especialidades;
        }

        public Especialidad GetOne(int id)
        {
            Especialidad especialidad = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidades where id_especialidad=@id", this.sqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    especialidad.ID = (int)drEspecialidad["id_especialidad"];
                    especialidad.Descripcion = (string)drEspecialidad["desc_especialidad"];

                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de la Especialidad", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return especialidad;
        }

        public void Update(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE especialidades " +
                                                    "SET desc_especialidad=@descripcion " +
                                                    "WHERE id_especialidad=@id", sqlConn);
                cmdUpdate.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar actualizar datos de la persona", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT into especialidades (desc_especialidad) " +
                                                      "VALUES (@descripcion) " +
                                                      "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                cmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar insertar datos de la especialidad", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar el especialidad", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}

