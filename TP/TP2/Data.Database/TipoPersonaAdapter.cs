using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class TipoPersonaAdapter : Adapter
    {
        public List<TipoPersona>GetAll()
        {
            List<TipoPersona> tipos = new List<TipoPersona>();
            this.OpenConnection();
            SqlCommand cmdTiposPersonas = new SqlCommand("select * from tipos_personas",this.sqlConn);
            SqlDataReader drTiposPersonas = cmdTiposPersonas.ExecuteReader();
            while (drTiposPersonas.Read())
            {
                TipoPersona tipo = new TipoPersona();

                tipo.IDTipoPersona = (int)drTiposPersonas["id_tipo_persona"];
                tipo.Descripcion = (string)drTiposPersonas["desc_tipo_persona"];

                tipos.Add(tipo);
            }
            this.CloseConnection();
            return tipos;
        } 
    }
}
