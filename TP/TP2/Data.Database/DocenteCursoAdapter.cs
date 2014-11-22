using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> DocentesCursos = new List<DocenteCurso>();
            this.OpenConnection();
            SqlCommand cmdDocentesCursos = new SqlCommand("select dc.id_dictado, dc.id_curso, dc.id_docente, per.nombre, " +
                                                          "per.apellido, mat.desc_materia, com.desc_comision, dc.cargo " +
                                                          "from docentes_cursos dc inner join cursos cu " +
                                                          "on dc.id_curso = cu.id_curso " +
                                                          "inner join personas per " +
                                                          "on per.id_persona = dc.id_docente " +
                                                          "inner join materias mat " +
                                                          "on mat.id_materia = cu.id_materia " +
                                                          "inner join comisiones com " +
                                                          "on com.id_comision = cu.id_comision " +
                                                          "order by per.nombre asc", this.sqlConn);
            SqlDataReader drDocentesCursos = cmdDocentesCursos.ExecuteReader();
            while (drDocentesCursos.Read())
            {
                DocenteCurso docCurso = new DocenteCurso();
                docCurso.ID = (int)drDocentesCursos["id_dictado"];
                docCurso.IDCurso = (int)drDocentesCursos["id_curso"];
                docCurso.IDDocente = (int)drDocentesCursos["id_docente"];
                docCurso.NombreDocente = (string)drDocentesCursos["nombre"];
                docCurso.ApellidoDocente = (string)drDocentesCursos["apellido"];
                docCurso.DescMateria = (string)drDocentesCursos["desc_materia"];
                docCurso.DescComision = (string)drDocentesCursos["desc_comision"];
                docCurso.Cargo = (DocenteCurso.TiposCargos)drDocentesCursos["cargo"];
                DocentesCursos.Add(docCurso);
            }
            this.CloseConnection();
            return DocentesCursos;
        }

        public DocenteCurso GetOne(int id)
        {
            DocenteCurso docCurso = new DocenteCurso();
            this.OpenConnection();
            SqlCommand cmdDocCurso = new SqlCommand("select * from docentes_cursos where id_dictado=@id", this.sqlConn);
            cmdDocCurso.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataReader drDocCurso = cmdDocCurso.ExecuteReader();
            while (drDocCurso.Read())
            {
                docCurso.ID = (int)drDocCurso["id_dictado"];
                docCurso.IDCurso = (int)drDocCurso["id_curso"];
                docCurso.IDDocente = (int)drDocCurso["id_docente"];
                docCurso.Cargo = (DocenteCurso.TiposCargos)drDocCurso["cargo"];
            }
            this.CloseConnection();
            return docCurso;
        }

        public void Insert(DocenteCurso DocenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("insert into docentes_cursos (id_curso, id_docente, cargo) " +
                                                      "values(@id_curso,@id_docente,@cargo ) " +
                                                      "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id_curso", SqlDbType.Int).Value = DocenteCurso.IDCurso;
                cmdInsert.Parameters.Add("@id_docente", SqlDbType.Int).Value = DocenteCurso.IDDocente;
                cmdInsert.Parameters.Add("@cargo", SqlDbType.Int).Value = DocenteCurso.Cargo;
                //cmdInsert.ExecuteNonQuery();
                DocenteCurso.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar insertar datos de la asignación del docente al curso.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar eliminar la asignación del docente al curso.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(DocenteCurso DocenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE docentes_cursos SET id_curso=@id_curso, id_docente=@id_docente ,cargo=@cargo " +
                                                      "WHERE id_dictado=@id_dictado", sqlConn);

                cmdUpdate.Parameters.Add("@id_dictado", SqlDbType.Int).Value = DocenteCurso.ID;
                cmdUpdate.Parameters.Add("@id_curso", SqlDbType.Int).Value = DocenteCurso.IDCurso;
                cmdUpdate.Parameters.Add("@id_docente", SqlDbType.Int).Value = DocenteCurso.IDDocente;
                cmdUpdate.Parameters.Add("@cargo", SqlDbType.Int).Value = DocenteCurso.Cargo;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al intentar actualizar datos de la asignación del docente al curso.", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso DocenteCurso)
        {
            if (DocenteCurso.State == BusinessEntity.States.New)
            {
                this.Insert(DocenteCurso);
            }
            else if (DocenteCurso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(DocenteCurso.ID);
            }
            else if (DocenteCurso.State == BusinessEntity.States.Modified)
            {
                this.Update(DocenteCurso);
            }
            DocenteCurso.State = BusinessEntity.States.Unmodified;
        }
    }
}
