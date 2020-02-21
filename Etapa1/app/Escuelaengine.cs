using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{

    public class Escuelaengine
    {

        public Escuelaengine(Escuela escuela)
        {
            this.Escuela = escuela;

        }
        public Escuela Escuela { get; set; }


        public Escuelaengine()
        {

        }

        public void inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota"); // nuevo objeto
            Escuela.TipoEscuela = TiposEscuela.Secundaria;
            Escuela.Cursos = new List<Curso>{ // lista en c#
            new Curso(){Nombre = "101", Jornada = tiposJornada.matutina},
            new Curso(){Nombre = "201", Jornada = tiposJornada.matutina},
            new Curso(){Nombre = "301", Jornada = tiposJornada.vespertina},
            new Curso(){Nombre = "401", Jornada = tiposJornada.vespertina},
            new Curso(){Nombre = "501", Jornada = tiposJornada.nocturna},
            new Curso(){Nombre = "601", Jornada = tiposJornada.nocturna},
            };
        }




    }






}