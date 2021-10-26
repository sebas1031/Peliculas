using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace MoviesProy.Shared.Entity
{
    public class Category
    {
        public int Id{get;set;}
        
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string Name{get;set;}

        public List<CategoryMovie> CategoriesMovie{get;set;} 
    }
}