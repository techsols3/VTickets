using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VTickets.Models;

namespace VTickets.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<ActorMovie>().HasOne(m =>
                m.Movie).WithMany(am => am.ActorsMovies)
                .HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<ActorMovie>().HasOne(m =>
                m.Actor).WithMany(am => am.ActorsMovies)
                .HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }




        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorMovie> ActorsMovies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }

    }
}
