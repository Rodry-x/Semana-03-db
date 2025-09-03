namespace Semana03_BD.Metodos
{
    public class MetodosPelicula
    {
        // Metodo para calcular la duracion total de una pelicula
        public string DuracionPelicula(int horas, int minutos, int segundos)
        {
            int totalSegundos = (horas * 3600) + (minutos * 60) + segundos;
            int duracionHoras = totalSegundos / 3600;
            int duracionMinutos = (totalSegundos % 3600) / 60;
            int duracionSegundos = totalSegundos % 60;
            return $"{duracionHoras} horas, {duracionMinutos} minutos, {duracionSegundos} segundos";
        }

        // Metodo para mostrar los datos de un ciudadano
        public string MostrarDatosCiudadano(string nombre, string apellido, int edad, int dni)
        {
            return $"Nombre: {nombre} {apellido}, Edad: {edad}, DNI: {dni}";
        }

        // Método para ordenar la lista de películas por duración (ascendente)
        private List<(string nombre, int horas, int minutos, int segundos)> OrdenarPorDuracion(
            List<(string nombre, int horas, int minutos, int segundos)> peliculas)
        {
            // Algoritmo de ordenamiento por selección
            for (int i = 0; i < peliculas.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < peliculas.Count; j++)
                {
                    int duracionMin = peliculas[minIndex].horas * 3600 + peliculas[minIndex].minutos * 60 + peliculas[minIndex].segundos;
                    int duracionJ = peliculas[j].horas * 3600 + peliculas[j].minutos * 60 + peliculas[j].segundos;
                    if (duracionJ < duracionMin)
                    {
                        minIndex = j;
                    }
                }
                // Intercambiar elementos
                var temp = peliculas[i];
                peliculas[i] = peliculas[minIndex];
                peliculas[minIndex] = temp;
            }
            return peliculas;
        }

        // Método para seleccionar solo los nombres de las películas
        private List<string> SeleccionarNombres(List<(string nombre, int horas, int minutos, int segundos)> peliculas)
        {
            List<string> nombres = new List<string>();
            foreach (var pelicula in peliculas)
            {
                nombres.Add(pelicula.nombre);
            }
            return nombres;
        }

        // Método principal que llama a los anteriores
        public List<string> OrdenarPeliculasAscendente(List<(string nombre, int horas, int minutos, int segundos)> peliculas)
        {
            var peliculasOrdenadas = OrdenarPorDuracion(new List<(string, int, int, int)>(peliculas));
            return SeleccionarNombres(peliculasOrdenadas);
        }
    }
}
