using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesProy.Client.Model;

namespace MoviesProy.Client.Services
{
    public interface TitleDataServiceInterface
    {
        Task<TitleData> GetMovie(String Title);
    }
}