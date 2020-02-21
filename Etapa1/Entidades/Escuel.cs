using System.Collections.Generic;
namespace CoreEscuela.Entidades
 {

public class Escuela 
{
string nombre;
public string Nombre { 
    get{return nombre; }
    set{nombre = value.ToUpper();}
}

public int AnodeCreacion { get; set; }
public string Pais { get; set; }
public string  Ciudad { get; set; }
public TiposEscuela TipoEscuela{ get; set; }

public  List<Curso> Cursos { get; set; }

public Escuela(string nombre, int Ano , string pais, string ciudad) => (Nombre,AnodeCreacion,Pais,Ciudad) = (nombre,Ano,pais,ciudad); // metodo para imprimir un objeto completo

public override string ToString() {
    return $"Nombre: {Nombre}, Tipo de Escuela: {TipoEscuela}, Pais: {Pais} , Ciudad: {Ciudad}";// metodo para imprimir un objeto completo
}


}















}