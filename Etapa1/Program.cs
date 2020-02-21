using System;
using CoreEscuela.Entidades;
using static System.Console; // Sirve para no tener que colocar System.ConsoleWriteLine = WriteLine
namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
          var engine = new Escuelaengine ();
          engine.inicializar();

        
            WriteLine("=====================");
            ImprimirCursosEscuela(engine.Escuela);


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