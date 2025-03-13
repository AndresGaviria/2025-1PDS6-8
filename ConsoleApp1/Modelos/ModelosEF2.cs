using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Modelos
{
    public class Tipos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
    }

    public class Animales
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }
        public string? Caracteristicas { get; set; }

        [ForeignKey("Tipo")] public Tipos? _Tipo { get; set; }
    }
}