using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Data.Database
{
    public class Adapter
    {

        private SqlConnection _sqlConn;

        public SqlConnection sqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }

        protected void OpenConnection()
        {
            sqlConn = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=academia; Integrated Security=true");
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }

    }
}
