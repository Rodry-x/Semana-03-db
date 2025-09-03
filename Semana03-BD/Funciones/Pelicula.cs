namespace Semana03_BD.Funciones
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public int Horas { get; set; }
        public int Minutos { get; set; }
        public int Segundos { get; set; }

        public Pelicula(string nombre, int horas, int minutos, int segundos)
        {
            Nombre = nombre;
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;
        }
    }
}
