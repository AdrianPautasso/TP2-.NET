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
    }
}
