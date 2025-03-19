using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Modelos
{
    public class Zapatos
    {
        public int Id { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Exportador { get; set; }
        public string? Marca { get; set; }
        public string? Talla { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("Exportador")] public Exportadores? _Exportador { get; set; }
    }
}