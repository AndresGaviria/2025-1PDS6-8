namespace ConsoleApp1.Modelos
{
    public class Usuarios
    {
        public int id;
        public string? nombre = null;
        public string? apellido = null;
        public DateTime fecha;
        public double edad;
        public bool genero;
        public TiposUsuarios? tipo;

        public Usuarios(int id, string? nombre, string? apellido, DateTime fecha, double edad, bool genero, TiposUsuarios? tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.edad = edad;
            this.genero = genero;
            this.tipo = tipo;
        }
    }

    public class TiposUsuarios
    {
        public int id;
        public string? nombre = null;

        public TiposUsuarios()
        {

        }

        public TiposUsuarios(int id, string? nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}