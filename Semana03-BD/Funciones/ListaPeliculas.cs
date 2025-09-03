namespace Semana03_BD.Funciones
{
    internal class ListaPeliculas
    {
        private List<Pelicula> peliculas = new List<Pelicula>();

        public void Agregar(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        public bool Eliminar(Pelicula pelicula)
        {
            return peliculas.Remove(pelicula);
        }

        public List<Pelicula> ObtenerTodas()
        {
            return new List<Pelicula>(peliculas);
        }

        public void Limpiar()
        {
            peliculas.Clear();
        }

        public int Contar()
        {
            return peliculas.Count;
        }
    }
}
