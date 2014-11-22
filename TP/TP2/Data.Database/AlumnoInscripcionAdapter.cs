using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> alumnos_inscripciones = new List<AlumnoInscripcion>();
            this.OpenConnection();
            SqlCommand cmdAlumnosInscripciones = new SqlCommand("select ai.id_inscripcion, per.nombre, per.apellido, per.legajo, " +
                                                                "mat.desc_materia, com.desc_comision, ai.condicion, isnull(ai.nota, 0) as nota " +
                                                                "from alumnos_inscripciones ai " +
                                                                "inner join personas per " +
                                                                "on per.id_persona = ai.id_alumno " +
                                                                "inner join cursos cur " +
                                                                "on cur.id_curso = ai.id_curso "+
                                                                "inner join materias mat " +
                                                                "on mat.id_materia = cur.id_materia " +
                                                                "inner join comisiones com " +
                                                                "on com.id_comision = cur.id_comision " +
                                                                "order by per.nombre asc ", this.sqlConn);
            SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();
            while (drAlumnosInscripciones.Read())
            {
                AlumnoInscripcion alumno_inscripcion = new AlumnoInscripcion();
                alumno_inscripcion.ID = (int)drAlumnosInscripciones["id_inscripcion"];
                alumno_inscripcion.NombreAlumno = (string)drAlumnosInscripciones["nombre"];
                alumno_inscripcion.ApellidoAlumno = (string)drAlumnosInscripciones["apellido"];
                alumno_inscripcion.LegajoAlumno = (int)drAlumnosInscripciones["legajo"];
                alumno_inscripcion.DescMateria = (string)drAlumnosInscripciones["desc_materia"];
                alumno_inscripcion.DescComision = (string)drAlumnosInscripciones["desc_comision"];
                alumno_inscripcion.Condicion = (string)drAlumnosInscripciones["condicion"];
                alumno_inscripcion.Nota = (int)drAlumnosInscripciones["nota"];
                alumnos_inscripciones.Add(alumno_inscripcion);
            }
            this.CloseConnection();
            return alumnos_inscripciones;
        }

        public AlumnoInscripcion GetOne(int id)
        {
            AlumnoInscripcion alumno_inscripcion = new AlumnoInscripcion();
            this.OpenConnection();
            SqlCommand cmdAlumnoInscripcion = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion=@id", this.sqlConn);
            cmdAlumnoInscripcion.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataReader drAlumnoInscripcion = cmdAlumnoInscripcion.ExecuteReader();
            while (drAlumnoInscripcion.Read())
            {
                alumno_inscripcion.ID = (int)drAlumnoInscripcion["id_inscripcion"];
                alumno_inscripcion.IDAlumno = (int)drAlumnoInscripcion["id_alumno"];
                alumno_inscripcion.IDCurso = (int)drAlumnoInscripcion["id_curso"];
                alumno_inscripcion.Condicion = (string)drAlumnoInscripcion["condicion"];
                alumno_inscripcion.Nota = (int)drAlumnoInscripcion["nota"];
            }
            this.CloseConnection();
            return alumno_inscripcion;
        }

        public void Delete(int id)
        {
            this.OpenConnection();
            SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where  id_inscripcion=@id", this.sqlConn);
            cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmdDelete.ExecuteNonQuery();
            this.CloseConnection();
        }

        public void Insert(AlumnoInscripcion alinsc)
        {
            this.OpenConnection();
            SqlCommand cmdInsert = new SqlCommand("insert into alumnos_inscripciones (id_alumno, id_curso, condicion, nota) " +
                                                  "values (@id_alumno, @id_curso, @condicion, @nota) " +
                                                  "select @@identity", this.sqlConn);
            cmdInsert.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alinsc.IDAlumno;
            cmdInsert.Parameters.Add("@id_curso", SqlDbType.Int).Value = alinsc.IDCurso;
            cmdInsert.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alinsc.Condicion;
            cmdInsert.Parameters.Add("@nota", SqlDbType.Int).Value = alinsc.Nota;
            alinsc.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            this.CloseConnection();
        }

        public void Update(AlumnoInscripcion alinsc)
        {
            this.OpenConnection();
            SqlCommand cmdUpdate = new SqlCommand("update alumnos_inscripciones set id_alumno=@id_alumno, " +
                                                  "id_curso=@id_curso, condicion=@condicion, nota=@nota " +
                                                  "where id_inscripcion=@id_inscripcion", this.sqlConn);
            cmdUpdate.Parameters.Add("id_alumno", SqlDbType.Int).Value = alinsc.IDAlumno;
            cmdUpdate.Parameters.Add("id_curso", SqlDbType.Int).Value = alinsc.IDCurso;
            cmdUpdate.Parameters.Add("condicion", SqlDbType.VarChar, 50).Value = alinsc.Condicion;
            cmdUpdate.Parameters.Add("nota", SqlDbType.Int).Value = alinsc.Nota;
            cmdUpdate.Parameters.Add("id_inscripcion", SqlDbType.Int).Value = alinsc.ID;
            cmdUpdate.ExecuteNonQuery();
            this.CloseConnection();
        }

        public void Save(AlumnoInscripcion alinsc)
        {
            if (alinsc.State == BusinessEntity.States.New)
            {
                this.Insert(alinsc);
            }
            else if (alinsc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alinsc.ID);
            }
            else if (alinsc.State == BusinessEntity.States.Modified)
            {
                this.Update(alinsc);
            }
            alinsc.State = BusinessEntity.States.Unmodified;
        }

    }
}
