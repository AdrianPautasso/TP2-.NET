using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            this.OpenConnection();
            SqlCommand cmdMaterias = new SqlCommand("select mat.id_materia, mat.desc_materia, " +
                                                    "mat.hs_semanales, mat.hs_totales, pl.id_plan, pl.desc_plan " +
                                                    "from materias mat inner join planes pl " +
                                                    "on mat.id_plan = pl.id_plan " +
                                                    "order by mat.desc_materia asc ", this.sqlConn);
            SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
            while(drMaterias.Read())
            {
                Materia materia = new Materia();
                materia.ID = (int)drMaterias["id_materia"];
                materia.Descripcion = (string)drMaterias["desc_materia"];
                materia.HSSemanales = (int)drMaterias["hs_semanales"];
                materia.HSTotales = (int)drMaterias["hs_totales"];
                materia.IDPlan = (int)drMaterias["id_plan"];
                materia.DescPlan = (string)drMaterias["desc_plan"];
                materias.Add(materia);
            }
            this.CloseConnection();
            return materias;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar la materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) " +
                                                      "values(@desc_materia,@hs_semanales,@hs_totales ,@id_plan) " +
                                                      "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdInsert.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdInsert.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                //cmdInsert.ExecuteNonQuery();
                materia.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar insertar datos de la materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE materias SET desc_materia=@desc_materia, hs_semanales=@hs_semanales,hs_totales=@hs_totales ,id_plan=@id_plan " +
                                                      "WHERE id_materia=@id_materia", sqlConn);
                cmdUpdate.Parameters.Add("@id_materia", SqlDbType.Int).Value = materia.ID;
                cmdUpdate.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdUpdate.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdUpdate.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar actualizar datos de la materia", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
