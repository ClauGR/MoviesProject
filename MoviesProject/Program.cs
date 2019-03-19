using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MoviesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "movies.json");
            var movies = DeserialiseMovies(fileName);


            foreach (var movie in movies)
            {
                Console.WriteLine(movie.MovieTitle);
                
            }
        }

            public static List<Movie> DeserialiseMovies(string fileName)
            {
                var movies = new List<Movie>();
                var serializer = new JsonSerializer();
                using (var reader = new StreamReader(fileName))

                using (var jsonReader = new JsonTextReader(reader))
                {
                    movies = serializer.Deserialize<List<Movie>>(jsonReader);
                }

                return movies;

            }





     
    }
}

