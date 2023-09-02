using Microsoft.EntityFrameworkCore;
using proiect.Models;

namespace proiect.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Film>().HasKey(af => new
            {
                af.IdActor,
                af.IdFilm
            });

            modelBuilder.Entity<Actor_Film>().HasOne(f => f.Film).WithMany(af => af.Actori_Filme).HasForeignKey(f => f.IdFilm);


            modelBuilder.Entity<Actor_Film>().HasOne(f => f.Actor).WithMany(af => af.Actori_Filme).HasForeignKey(f => f.IdActor);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actori { get; set; }
        public DbSet<Film> Filme { get; set; }
        public DbSet<Actor_Film> Actori_Filme { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producator> Producatori { get; set; }

    }
}
