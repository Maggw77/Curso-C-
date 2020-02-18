using System;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string id { get; private set; }
        public string Nombre { get; set; }

        public tiposJornada Jornada { get; set; }

        public Curso()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}