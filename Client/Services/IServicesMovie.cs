using MoviesProy.Shared.Entity;
using System.Collections.Generic;

namespace MoviesProy.Client.Services
{
    public interface IServicesMovie
    {
        List<Movie> GetMovies();
    }
}