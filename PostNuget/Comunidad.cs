using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostNuget
{
    class Comunidad
    {
        public List<Persona> GetPersonas() 
        {
            List<Persona> personas = new List<Persona>();
            Persona p = new Persona
            {
                IdPersona = 1,
                Nombre = "Juan",
                Apellido = "Cardenas",
                Edad = 14,
                Sexo = "Hombre"
            };
            personas.Add(p);
            Persona p1 = new Persona
            {
                IdPersona = 1,
                Nombre = "Carlos",
                Apellido = "Jimenez",
                Edad = 28,
                Sexo = "Hombre"
            };
            personas.Add(p1);
            Persona p2 = new Persona
            {
                IdPersona = 1,
                Nombre = "Pedro",
                Apellido = "Ramos",
                Edad = 17,
                Sexo = "Hombre"
            };
            personas.Add(p2);
            Persona p3 = new Persona
            {
                IdPersona = 1,
                Nombre = "Marta",
                Apellido = "Valencia",
                Edad = 10,
                Sexo = "Mujer"
            };
            personas.Add(p3);
            Persona p4 = new Persona
            {
                IdPersona = 1,
                Nombre = "Sonia",
                Apellido = "León",
                Edad = 45,
                Sexo = "Mujer"
            };
            personas.Add(p4);
            Persona p5 = new Persona
            {
                IdPersona = 1,
                Nombre = "Yesica",
                Apellido = "Cardenas",
                Edad = 18,
                Sexo = "Mujer"
            };
            personas.Add(p5);
            return personas;
        }
        public Persona FindPersona(int id) 
        {
            return this.GetPersonas().FirstOrDefault(z => z.IdPersona == id);
        }
    }
}
