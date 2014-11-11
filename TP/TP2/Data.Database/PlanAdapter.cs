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
            SqlCommand cmdPlanes = new SqlCommand("select * from planes", this.sqlConn);
            SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
            while (drPlanes.Read())
            {
                Plan plan = new Plan();
                plan.ID = (int)drPlanes["id_plan"];
                plan.IDEspecialidad = (int)drPlanes["id_especialidad"];
                plan.Descripcion = (string)drPlanes["desc_plan"];
                planes.Add(plan);
            }
            this.CloseConnection();
            return planes;
        }
    }
}
