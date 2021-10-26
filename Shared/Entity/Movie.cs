using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace MoviesProy.Shared.Entity
{
    public class Movie
    {
        [Required (ErrorMessage="El campo {0} es requerido")]
        public DateTime? premier{get;set;}
        
        public int Id{get;set;}
        public string name{get;set;}
        public string actors{get;set;}
        public double rating{get;set;}
        public string image{get;set;}
        public string trailer{get;set;}
        public string sinopsis{get;set;}

        public List<CategoryMovie> CategoriesMovie{get;set;} = new List<CategoryMovie>(); 
        public List<MovieActor> MoviesActors{get;set;}
    }
    
}