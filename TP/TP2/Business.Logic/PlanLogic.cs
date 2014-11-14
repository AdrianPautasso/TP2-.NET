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
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter planData;

        public PlanLogic()
        {
            planData = new PlanAdapter();
        }

        public PlanAdapter PlanData
        {
            get { return planData; }
            set { planData = value; }
        }

        public List<Plan> GetAll()
        {
            return planData.GetAll();
        }

        public Plan GetOne(int id)
        {
            try
            {
                return PlanData.GetOne(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Save(Plan plan)
        {
            PlanData.Save(plan);
        }

        public void Delete(int id)
        {
            PlanData.Delete(id);
        }
    }
}
