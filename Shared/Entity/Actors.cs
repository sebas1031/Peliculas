using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace MoviesProy.Shared.Entity
{
    public class Actor
    {
        public int Id{get;set;}
        [Required (ErrorMessage="El campo {0} es requerido")]
        public string actorName{get;set;}
        
        [Required (ErrorMessage="El campo {0} es requerido")]
        public string biography{get;set;}
        
        public Gender gender{get;set;}
        public DateTime? birthDate{get;set;}
        public int nominations{get;set;}
        public string Photo{get;set;}
        public List<MovieActor> MoviesActors{get;set;}
    }
    public enum Gender
    {
        Femenino = 0,
        Masculino = 1
    }
}