using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            this.OpenConnection();
            SqlCommand cmdPlanes = new SqlCommand("SELECT pl.id_plan, pl.desc_plan, es.id_especialidad, " +
                                                   "es.desc_especialidad " +
                                                   "FROM planes pl INNER JOIN especialidades es " +
                                                   "ON pl.id_especialidad = es.id_especialidad " + 
                                                   "ORDER BY pl.desc_plan ASC", this.sqlConn);
            SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
            while (drPlanes.Read())
            {
                Plan plan = new Plan();
                plan.ID = (int)drPlanes["id_plan"];
                plan.IDEspecialidad = (int)drPlanes["id_especialidad"];
                plan.Descripcion = (string)drPlanes["desc_plan"];
                plan.DescEspecialidad = (string)drPlanes["desc_especialidad"];
                planes.Add(plan);
            }
            this.CloseConnection();
            return planes;
        }

        public Plan GetOne(int id)
        {
            Plan plan = new Plan();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("select * from planes where id_plan=@id", this.sqlConn);
                cmdPlan.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drPlan = cmdPlan.ExecuteReader();
                while (drPlan.Read())
                {
                    plan.ID = (int)drPlan["id_plan"];
                    plan.Descripcion = (string)drPlan["desc_plan"];
                    plan.IDEspecialidad = (int)drPlan["id_especialidad"];
                }
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar datos del Plan", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return plan;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plan=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar el Plan", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Plan plan)
        {
            //try
            //{
            this.OpenConnection();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE planes SET desc_plan=@desc_plan, id_especialidad=@id_especialidad " +
                                                  "WHERE id_plan=@id_plan", sqlConn);
            cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = plan.ID;
            cmdUpdate.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
            cmdUpdate.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
            cmdUpdate.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada =
            //    new Exception("Error al intentar actualizar datos del Plan", ex);
            //    throw ExcepcionManejada;
            //}
            //finally
            //{
            this.CloseConnection();
            //}
        }

        public void Insert(Plan plan)
        {
            //try
            //{
            this.OpenConnection();
            SqlCommand cmdInsert = new SqlCommand("insert into planes (desc_plan, id_especialidad) " +
                                                  "values(@desc_plan,@id_especialidad) " +
                                                  "select @@identity", sqlConn);
            cmdInsert.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
            cmdInsert.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
            plan.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            //}
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada =
            //    new Exception("Error al intentar insertar datos del Plan", ex);
            //    throw ExcepcionManejada;
            //}
            //finally
            //{
            this.CloseConnection();
            //}
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

    }
}