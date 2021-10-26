using Microsoft.EntityFrameworkCore;
using MoviesProy.Shared.Entity;
using System.Collections.Generic;
namespace MoviesProy.Server
{
    public class AplicationDB: DbContext
    {
        public DbSet<Actor> Actors{get;set;}
        public DbSet<Movie> Movies{get;set;}
        public DbSet<Category> Categories{get;set;}
        public DbSet<CategoryMovie> CategoriesMovies{get;set;}
        public DbSet<MovieActor> MoviesActors{get;set;}

        public AplicationDB(DbContextOptions<AplicationDB> options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CategoryMovie>().HasKey(x=> new {x.CategoryId, x.MovieId});
            modelBuilder.Entity<MovieActor>().HasKey(x=> new {x.MovieId, x.ActorId});
            base.OnModelCreating(modelBuilder);
        }
    }
}