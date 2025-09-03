using Semana03_BD.Funciones;
using Semana03_BD.Metodos;

namespace Semana03_BD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var metodosPeliculas = new MetodosPeliculas();
            var listaPeliculas = new ListaPeliculas();

            while (true)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("---------  Listas Peliculas  ------------");
                Console.WriteLine("1. Ordenar peliculas (ascendente)");
                Console.WriteLine("2. Registrar un conjunto de ciudadanos");
                Console.WriteLine("3. (En desarrollo)");
                Console.WriteLine("4. Leer 3 listas (X,Y,Z)");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=========================================");
                Console.Write("Seleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Usar MetodosPeliculas para ordenar y mostrar duración
                        var peliculasTuplas = listaPeliculas.ObtenerTodas()
                            .Select(p => (p.Nombre, p.Horas, p.Minutos, p.Segundos))
                            .ToList();
                        var nombresOrdenados = metodosPeliculas.OrdenarPeliculasAscendente(peliculasTuplas);
                        Console.WriteLine("Películas ordenadas por duración:");
                        foreach (var nombre in nombresOrdenados)
                            Console.WriteLine(nombre);

                        // Mostrar la duración total de cada película (opcional)
                        foreach (var pelicula in peliculasTuplas)
                        {
                            string duracion = metodosPeliculas.DuracionPelicula(pelicula.Item2, pelicula.Item3, pelicula.Item4);
                            Console.WriteLine($"{pelicula.Item1}: {duracion}");
                        }
                        break;

                    case "2":
                        Console.Write("¿Cuántas películas desea registrar? ");
                        if (int.TryParse(Console.ReadLine(), out int cantidad))
                        {
                            listaPeliculas.Limpiar();
                            for (int i = 0; i < cantidad; i++)
                            {
                                Console.WriteLine($"Película {i + 1}:");
                                Console.Write("Nombre: ");
                                string nombre = Console.ReadLine();
                                Console.Write("Horas: ");
                                int horas = int.Parse(Console.ReadLine());
                                Console.Write("Minutos: ");
                                int minutos = int.Parse(Console.ReadLine());
                                Console.Write("Segundos: ");
                                int segundos = int.Parse(Console.ReadLine());
                                listaPeliculas.Agregar(new Pelicula(nombre, horas, minutos, segundos));
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Opción en desarrollo.");
                        break;

                    case "4":
                        Console.WriteLine("Funcionalidad para leer 3 listas (X,Y,Z) aún no implementada.");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
