// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesProy.Server;

namespace MoviesProy.Server.Migrations
{
    [DbContext(typeof(AplicationDB))]
    [Migration("20211010204724_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoviesProy.Shared.Entity.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("actorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("birthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.Property<int>("nominations")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.CategoryMovie", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "MovieId");

                    b.HasIndex("MovieId");

                    b.ToTable("CategoriesMovies");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("premier")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<double>("rating")
                        .HasColumnType("float");

                    b.Property<string>("sinopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.MovieActor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderCredits")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MoviesActors");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.CategoryMovie", b =>
                {
                    b.HasOne("MoviesProy.Shared.Entity.Category", "Category")
                        .WithMany("CategoriesMovie")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesProy.Shared.Entity.Movie", "Movie")
                        .WithMany("CategoriesMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.MovieActor", b =>
                {
                    b.HasOne("MoviesProy.Shared.Entity.Actor", "Actor")
                        .WithMany("MoviesActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MoviesProy.Shared.Entity.Movie", "Movie")
                        .WithMany("MoviesActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.Actor", b =>
                {
                    b.Navigation("MoviesActors");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.Category", b =>
                {
                    b.Navigation("CategoriesMovie");
                });

            modelBuilder.Entity("MoviesProy.Shared.Entity.Movie", b =>
                {
                    b.Navigation("CategoriesMovie");

                    b.Navigation("MoviesActors");
                });
#pragma warning restore 612, 618
        }
    }
}
