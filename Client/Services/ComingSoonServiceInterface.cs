using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesProy.Client.Model;

namespace MoviesProy.Client.Services
{
    public interface ComingSoonServiceInterface
    {
        Task<NewMovieData> GetAllMovies();
    }
}