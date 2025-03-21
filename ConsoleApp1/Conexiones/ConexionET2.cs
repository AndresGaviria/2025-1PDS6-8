using ConsoleApp1.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Conexiones
{
    public class ConexionEF2
    {
        private string string_conexion = "server=localhost;database=db_zoo;Integrated Security=True;TrustServerCertificate=true;";
        // server=localhost;database=db_zoo;uid=sa;pwd=Clas3sPrO2024_!;TrustServerCertificate=true;
        // server=localhost;database=db_zoo;Integrated Security=True;TrustServerCertificate=true;

        public void ConexionBasica()
        {
            var conexion = new Conexion2();
            conexion.StringConnection = this.string_conexion;

            var lista = conexion.Animales.ToList();

            foreach (var elemento in lista)
            {
                Console.WriteLine(elemento.Id.ToString() + ", " + 
                    elemento.Codigo + ", " + 
                    elemento.Nombre + ", " + 
                    elemento.Tipo.ToString() + ", " + 
                    elemento.Fecha.ToString() + ", " + 
                    elemento.Activo.ToString());
            }
        }

        public void ConexionInsert()
        {
            var conexion = new Conexion2();
            conexion.StringConnection = this.string_conexion;

            var animal = new Animales();
            animal.Codigo = "2315456";
            animal.Nombre = "Pepe";
            animal.Tipo = 2;
            animal.Fecha = DateTime.Now;
            animal.Activo = false;

            conexion.Animales.Add(animal);
            conexion.SaveChanges();
        }
    }

    public partial class Conexion2 : DbContext
    {
        public string? StringConnection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConnection!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Tipos>? Tipos { get; set; }
        public DbSet<Animales>? Animales { get; set; }
    }
}