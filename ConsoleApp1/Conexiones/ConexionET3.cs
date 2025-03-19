using ConsoleApp1.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Conexiones
{
    public class ConexionEF3
    {
        private string string_conexion = "server=localhost;database=db_zapatos;Integrated Security=True;TrustServerCertificate=true;";
        // server=localhost;database=db_zapatos;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_zapatos;Integrated Security=True;TrustServerCertificate=true;

        public void ConexionBasica()
        {
            var conexion = new Conexion3();
            conexion.StringConnection = this.string_conexion;

            var lista = conexion.Zapatos.ToList();

            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento.Id.ToString() + ", " + 
                    elemento.Nombre);
            }
        }

        public void ConexionInsert()
        {
            var conexion = new Conexion3();
            conexion.StringConnection = this.string_conexion;

            var exportador = conexion.Exportadores
                .FirstOrDefault(x => x.Nombre == "Coordinadora");

            if (exportador == null)
                return;

            var zapatos = new Zapatos();
            zapatos.Codigo = "ZP-46565";
            zapatos.Nombre = "Zapatilla";
            zapatos.Cantidad = 2;
            zapatos.Exportador = exportador!.Id;
            zapatos.Marca = "Reebook";
            zapatos.Talla = "45";
            zapatos.Fecha = DateTime.Now;
            zapatos.Activo = false;

            conexion.Zapatos.Add(zapatos);
            conexion.SaveChanges();
        }
    }

    public partial class Conexion3 : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Exportadores>? Exportadores { get; set; }
        public DbSet<Zapatos>? Zapatos { get; set; }
    }
}