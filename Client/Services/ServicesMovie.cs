using System;
using MoviesProy.Shared.Entity;
using System.Collections.Generic;

namespace MoviesProy.Client.Services
{
    public class ServicesMovie: IServicesMovie
    {
        public List<Movie> GetMovies(){
            return new List<Movie>{
                new Movie(){Id=1,sinopsis="Resumen de la pelicula...",premier=new DateTime(2021,01,31),name="Malignant",actors="Annabelle Walls, Maddie Hasson", rating=6.3,image="/Images/Movies/maligno.jpg"},
                new Movie(){Id=2,sinopsis="Resumen de la pelicula...",premier=new DateTime(2021,02,16),name="Dune",actors="Timothee Chalamet, Rebecca Ferguson", rating=8.5,image="/Images/Movies/dune.jpeg"},
                new Movie(){Id=3,sinopsis="Resumen de la pelicula...",premier=new DateTime(2021,03,27),name="Shang-Chi and the Legend of the Ten Rings", actors="Simu Liu, Destin Cretton",rating=7.9,image="/Images/Movies/chinita.jpg"},
                new Movie(){Id=4,sinopsis="Resumen de la pelicula...",premier=new DateTime(2021,04,07),name="Cinderella",actors="Camila Cabello, Billy Potter",rating=4.2,image="/Images/Movies/cinderella.jpg"},
                new Movie(){Id=5,sinopsis="Resumen de la pelicula...",premier=new DateTime(2021,05,14),name="The Matrix Resurrections",actors="Keanu Reaves, Carrie Anne Moss",rating=4.8,image="/Images/Movies/matrix.jpg"},
                new Movie(){Id=6,sinopsis="Resumen de la pelicula...",premier=new DateTime(2021,06,26),name="Cry Macho",actors="Clint Weastwood, Fernanda Urrejola", rating=5.9,image="/Images/Movies/cryMacho.jpg"}
            };
        }
    }
}