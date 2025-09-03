namespace Semana03_BD.Metodos
{
    internal class Metodos
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
    }
}
