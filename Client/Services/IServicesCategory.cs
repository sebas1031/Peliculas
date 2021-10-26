using MoviesProy.Shared.Entity;
using System.Collections.Generic;

namespace MoviesProy.Client.Services
{
    public interface IServicesCategory
    {
        List<Category> GetCategories();
    }
}