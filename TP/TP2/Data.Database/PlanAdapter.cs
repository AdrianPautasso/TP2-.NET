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
        public List<Business.Entities.Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            this.OpenConnection();
            SqlCommand cmdPlanes = new SqlCommand("SELECT pl.id_plan, pl.desc_plan, es.id_especialidad, " + 
                                                   "es.desc_especialidad " +
                                                   "FROM planes pl INNER JOIN especialidades es " +
                                                   "ON pl.id_especialidad = es.id_especialidad ", this.sqlConn);
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
    }
}
