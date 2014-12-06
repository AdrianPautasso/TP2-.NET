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
    public class PersonaLogic : BusinessLogic
    {
        private PersonaAdapter personaData;

        public PersonaLogic()
        {
            personaData = new PersonaAdapter();
        }

        public PersonaAdapter PersonaData
        {
            get { return personaData; }
            set { personaData = value; }
        }

        public List<Persona> GetAll()
        {
             return this.PersonaData.GetAll();
        }

        public List<Persona> GetPersona(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas = PersonaData.GetAll();
            List<Persona> persona = new List<Persona>();
            foreach (var per in personas)
                if (per.ID == id)
                    persona.Add(per);
            return persona;
        }

        public List<Persona> GetAll(int id_tipo_persona)
        {
            List<Persona> personas = new List<Persona>();
            if (id_tipo_persona == 1)
                foreach (var persona in PersonaData.GetAll())
                    if (persona.IDTipoPersona == 1)
                        personas.Add(persona);
            if (id_tipo_persona == 2)
                foreach (var persona in PersonaData.GetAll())
                    if (persona.IDTipoPersona == 2)
                        personas.Add(persona);
            if (id_tipo_persona == 3)
                foreach (var persona in PersonaData.GetAll())
                    if (persona.IDTipoPersona == 3)
                        personas.Add(persona);
            return personas;
        }

        public Persona GetOne(int id)
        {
            //try
            //{
                Persona persona = new Persona();
                foreach (var p in this.GetAll())
                    if (p.ID == id)
                        persona = p;
                return persona;
            //}
            //catch (Exception e)
            //{
            //    throw e;
            //}
        }

        public void Save(Persona persona)
        {
            PersonaData.Save(persona);
        }

        public void Delete(int id)
        {
            PersonaData.Delete(id);
        }

        public int GetTipoPer(int id)
        {
            //try
            //{
                Persona per = this.GetOne(id);
                return per.IDTipoPersona;
            //}
            //catch (Exception ExcepcionManejada)
            //{
            //    throw ExcepcionManejada;
            //}
        }

        public Persona GetAlumnoInscripcion(int idInscripcion)
        {
            return PersonaData.GetAlumnoInscripcion(idInscripcion);
        }

    }
}
