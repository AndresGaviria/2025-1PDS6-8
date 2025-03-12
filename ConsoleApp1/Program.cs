using ConsoleApp1.Modelos;
using ConsoleApp1.Conexiones;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var tipo1 = new TiposUsuarios(1, "Admin");
var tipo2 = new TiposUsuarios(2, "Normal");

var lista = new List<TiposUsuarios>();
lista.Add(tipo1);
lista.Add(tipo2);

var tipo = lista.FirstOrDefault(x => x.id == 1);
if (tipo != null)
{
    Console.WriteLine(tipo!.nombre);
}

Usuarios usuario = new Usuarios(
    1, 
    "Pepito", 
    "Perez", 
    DateTime.Now, 
    27.0, 
    true, 
    tipo1
);
var nom = "Pepito";
var usuario2 = new Usuarios(
    1, 
    nom, 
    "Perez", 
    DateTime.Now, 
    27.0, 
    true, 
    new TiposUsuarios(3, "Estudiante")
);

var conexionEf = new ConexionEF();
conexionEf.ConexionBasica();