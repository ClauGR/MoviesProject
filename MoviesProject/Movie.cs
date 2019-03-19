using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace MoviesProject
{


    public class Rootobject
    {
        public Movie[] Property1 { get; set; }
    }

    public class Movie
    {
        [JsonProperty(PropertyName = "movie_title")]
        public string MovieTitle { get; set; }

        [JsonProperty(PropertyName = "movie_year")]
        public int MovieYear { get; set; }

        [JsonProperty(PropertyName = "movie_cast")]
        public string[] MovieCast { get; set; }

        [JsonProperty(PropertyName = "movie_genres")]
        public string[] MovieGenres { get; set; }
    }




}
