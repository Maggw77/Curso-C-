using System;
using CoreEscuela.Entidades;
using static System.Console; // Sirve para no tener que colocar System.ConsoleWriteLine = WriteLine
namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Myescuela = new Escuela("Platzi Academy", 2012, "Colombia", "Bogota"); // nuevo objeto
            Myescuela.TipoEscuela = TiposEscuela.Secundaria;
            Myescuela.Cursos = new Curso[] { // Segundo metodo para declarar un arreglo utilizando una clase "Curso"
                new Curso(){Nombre = "401"},
                new Curso(){Nombre = "501"},
                new Curso(){Nombre = "601"},
            };

            var LiceoCentro = new Escuela("Liceo Centroamericano", 2000, "Guatemala", "Guatemala City"); // nuevo objeto
            LiceoCentro.TipoEscuela = TiposEscuela.Primaria;

            var LiceoCUM = new Escuela("Liceo CUM", 1986, "Brasil", "Rio de Janeiro"); // nuevo objeto
            LiceoCUM.TipoEscuela = TiposEscuela.PreEscolar;


            Curso[] arregloCursos2 =   { // Segundo metodo para declarar un arreglo utilizando una clase "Curso"
                new Curso(){Nombre = "401",Jornada=tiposJornada.matutina},
                new Curso(){Nombre = "501",Jornada=tiposJornada.vespertina},
                new Curso(){Nombre = "601",Jornada=tiposJornada.nocturna},
            };


            ImprimirCursosEscuela(Myescuela);
            WriteLine(LiceoCentro);


        }

        private static void ImprimirCursosEscuela(Escuela myescuela)
        {
            WriteLine("==============================");
            WriteLine("Cursos de la escuela");
            WriteLine("==============================");
            if (myescuela?.Cursos != null)
                foreach (var curso in myescuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.id}");
                }

        }





        /* private static void ConteoArregloswhile(Curso[] arregloCursos) // Metodo o funcion para recorrer un arreglo con While
         {
             int contador = 0;
             while (contador < arregloCursos.Length)
             {
                 WriteLine($"Nombre: {arregloCursos[contador].Nombre}, Id: {arregloCursos[contador].id}");
                 contador += 1;
             }
         }
           ConteoArregloswhile(arregloCursos2); // imprimir un metodo o llamar una funcion usando un arreglo



         private static void ConteoArreglosfor(Curso[] arregloCursos)
         {  // Metodo o funcion para recorrer un arreglo con for
             for (int i = 0; i < arregloCursos.Length; i++)
             {
                 WriteLine($"Nombre: {arregloCursos[i].Nombre}, Id: {arregloCursos[i].id}");
             }
         }
        
        ConteoArreglosfor(arregloCursos2);



         private static void ConteoArreglosforeach(Curso[] arregloCursos)
         {  // Metodo o funcion para recorrer un arreglo con foreach el mejor de todos los metodos
             foreach (var curso in arregloCursos)
             {
                 WriteLine($"Nombre: {curso.Nombre}, Id: {curso.id}");
             }

         } 

          private static void arregloforeach(Curso[] arregloCursos) // usando foreach
        {
            foreach (var curso in arregloCursos)
            {
                WriteLine($"Nombre: {curso.Nombre}, Id: {curso.id}");
            }
        }


         //System.Console.WriteLine(curso1.Nombre+ ", "+curso1.id); forma basica de imprimir en pantalla
         //System.Console.WriteLine($"{curso2.Nombre}, {curso2.id}"); nueva forma utilizando string con variables $
         // System.Console.WriteLine(curso3.Nombre+ ", "+curso3.id);
         WriteLine(LiceoCentro); imprimir un objeto comleto pero necesita una funcion revisar el metodo
         
         */


    }

}