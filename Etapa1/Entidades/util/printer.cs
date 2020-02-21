using static System.Console;

namespace CoreEscuela.util {


public static class Printer {



public static void Linea(int tam = 10 ) {

WriteLine("".PadLeft(tam,'='));

}

public static void titulo(string titulo ) {
var tam = titulo.Length + 4;
Linea(tam);
WriteLine($"| {titulo} |");
Linea(tam);

}

public static void Beep(int hz=2000,int tiempo=500,int cantidad=4) {

while (cantidad-- > 0)
{
    System.Console.Beep(hz,tiempo);
}

}


}

}