using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
            new Movie() {Title = "Spiderman", ReleaseDate = new DateTime(2019, 7, 2), Poster = "https://images.theconversation.com/files/175539/original/file-20170626-315-1h7k01d.jpg?ixlib=rb-1.1.0&q=45&auto=format&w=496&fit=clip" },
            new Movie() {Title = "Moana", ReleaseDate = DateTime.Today, Poster = "https://upload.wikimedia.org/wikipedia/en/thumb/2/26/Moana_Teaser_Poster.jpg/220px-Moana_Teaser_Poster.jpg"}
            };

            return movies;
        }
    }
}
