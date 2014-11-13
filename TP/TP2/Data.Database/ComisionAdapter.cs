using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            this.OpenConnection();
            SqlCommand cmdComisiones = new SqlCommand("select * from comisiones", this.sqlConn);
            SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
            while (drComisiones.Read())
            {
                Business.Entities.Comision comision = new Comision();
                comision.ID = (int)drComisiones["id_comision"];
                comision.Descripcion = (string)drComisiones["desc_comision"];
                comision.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                comision.IDPlan = (int)drComisiones["id_plan"];
                comisiones.Add(comision);
            }
            this.CloseConnection();
            return comisiones;

        }

        public Comision GetOne(int id)
        {
            Comision comision = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones where id_comision=@id", this.sqlConn);
                cmdComision.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                while (drComision.Read())
                {
                    comision.ID = (int)drComision["id_comision"];
                    comision.Descripcion = (string)drComision["desc_comision"];
                    comision.AnioEspecialidad = (int)drComision["anio_especialidad"];
                    comision.IDPlan = (int)drComision["id_plan"];
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos de la Comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comision;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar la comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Comision comision)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE comisiones " +
                                           "SET desc_comision=@descripcion " +
                                            "anio_especialidad=@anioEspecialidad " +
                                            "WHERE id_comision=@id", sqlConn);
                cmdUpdate.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdUpdate.Parameters.Add("@anioEspecialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar actualizar datos de la comision", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Comision comision)
        {
            //try
            //{
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT into comisiones (desc_comision, anio_especialidad) " +
                                                      "VALUES (@descripcion, @anioEspecialidad) " +
                                                      "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdInsert.Parameters.Add("@anioEspecialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdInsert.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada =
            //    new Exception("Error al intentar insertar datos de la comision", ex);
            //    throw ExcepcionManejada;
            //}
            //finally
            //{
                this.CloseConnection();
            //}
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
