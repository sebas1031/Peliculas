using MoviesProy.Shared.Entity;
using System.Collections.Generic;

namespace MoviesProy.Client.Services
{
    public interface IServicesActor
    {
        List<Actor> GetActor();
    }
}