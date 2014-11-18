using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            this.OpenConnection();
            SqlCommand cmdCursos = new SqlCommand("SELECT cur.id_curso, cur.id_materia, mat.desc_materia, cur.id_comision, " +
                                                	"com.desc_comision, cur.anio_calendario, cur.cupo " +
                                                    "FROM cursos cur INNER JOIN materias mat " +
                                                    "ON cur.id_materia = mat.id_materia " +
                                                    "INNER JOIN comisiones com " +
                                                    "ON com.id_comision = cur.id_comision", this.sqlConn);
            SqlDataReader drCursos = cmdCursos.ExecuteReader();
            while(drCursos.Read())
            {
                Curso curso = new Curso();
                curso.ID = (int)drCursos["id_curso"];
                curso.IDMateria = (int)drCursos["id_materia"];
                curso.DescMateria = (string)drCursos["desc_materia"];
                curso.IDComision = (int)drCursos["id_comision"];
                curso.DescComision = (string)drCursos["desc_comision"];
                curso.AnioCalendario = (int)drCursos["anio_calendario"];
                curso.Cupo = (int)drCursos["cupo"];
                cursos.Add(curso);
            }
            this.CloseConnection();
            return cursos;
        }

        public Curso GetOne(int id)
        {
            Curso curso = new Curso();
            this.OpenConnection();
            SqlCommand cmdCurso = new SqlCommand("SELECT * FROM cursos WHERE id_curso=@id", this.sqlConn);
            cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataReader drCurso = cmdCurso.ExecuteReader();
            while(drCurso.Read())
            {
                curso.ID = (int)drCurso["id_curso"];
                curso.IDComision = (int)drCurso["id_comision"];
                curso.IDMateria = (int)drCurso["id_materia"];
                curso.AnioCalendario = (int)drCurso["anio_calendario"];
                curso.Cupo = (int)drCurso["cupo"];
            }
            this.CloseConnection();
            return curso;
        }

        public void Insert(Curso curso)
        {
            //try
            //{
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into cursos (id_materia, id_comision, anio_calendario, cupo) " +
                                                      "values(@id_materia,@id_comision,@anio_calendario ,@cupo) " +
                                                      "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdInsert.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdInsert.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdInsert.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                //cmdInsert.ExecuteNonQuery();
                curso.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            //}
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada =
            //    new Exception("Error al intentar insertar datos del curso", ex);
            //    throw ExcepcionManejada;
            //}
            //finally
            //{
                this.CloseConnection();
            //}
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar el curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Curso curso)
        {
            ////try
            ////{
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE cursos SET id_materia=@id_materia, id_comision=@id_comision, anio_calendario=@anio_calendario ,cupo=@cupo " +
                                                      "WHERE id_curso=@id_curso", sqlConn);

                cmdUpdate.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.ID;
                cmdUpdate.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdUpdate.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdUpdate.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdUpdate.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmdUpdate.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    Exception ExcepcionManejada =
            //    new Exception("Error al intentar actualizar datos del curso", ex);
            //    throw ExcepcionManejada;
            //}
            //finally
            //{
                this.CloseConnection();
            //}
        }

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
