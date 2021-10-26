using MoviesProy.Shared.Entity;
using System.Collections.Generic;
using System;
namespace MoviesProy.Client.Services
{
    public class ServicesActor: IServicesActor
    {
        public List <Actor> GetActor(){
            return new List <Actor>{
                new Actor(){Id=1,actorName="Sebastian",biography="Leve descripcion del actor",gender=Gender.Masculino,nominations=10,birthDate=new DateTime(2000,10,31),Photo="/Images/Actors/Tom.jpg"},
                new Actor(){Id=2,actorName="Sergio",biography="Leve descripcion del actor",gender=Gender.Masculino,nominations=9,birthDate=new DateTime(1992,09,08),Photo="/Images/Actors/Tom.jpg"},
                new Actor(){Id=3,actorName="Andrea",biography="Leve descripcion del actor",gender=Gender.Femenino,nominations=8,birthDate=new DateTime(2003,06,25),Photo="/Images/Actors/Alexandra.jpg"},
                new Actor(){Id=4,actorName="Lili Johana",biography="Leve descripcion del actor",gender=Gender.Femenino,nominations=7,birthDate=new DateTime(2000,10,08),Photo="/Images/Actors/Alexandra.jpg"},
                new Actor(){Id=5,actorName="Mariana",biography="Leve descripcion del actor",gender=Gender.Femenino,nominations=6,birthDate=new DateTime(2000,10,08),Photo="/Images/Actors/Alexandra.jpg"},
                new Actor(){Id=6,actorName="Santiago",biography="Leve descripcion del actor",gender=Gender.Masculino,nominations=4,birthDate=new DateTime(2000,10,08),Photo="/Images/Actors/Tom.jpg"}
            };
        } 
    }
}