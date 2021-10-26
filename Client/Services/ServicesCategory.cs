using MoviesProy.Shared.Entity;
using System.Collections.Generic;
namespace MoviesProy.Client.Services
{
    public class ServicesCategory: IServicesCategory
    {
        public List <Category> GetCategories(){
            return new List <Category>{
                new Category(){Id=1,Name="Terror"},
                new Category(){Id=2,Name="Accion"},
                new Category(){Id=3,Name="Aventura"},
                new Category(){Id=4,Name="Fantasia"},
                new Category(){Id=5,Name="Animados"},
                new Category(){Id=6,Name="Suspenso"}
            };
        } 
    }
}