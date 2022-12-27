using AutoKomis.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoKomis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Komis>()
                .HasKey(x => x.Id);


            builder.Entity<Pracownik>()
                .HasKey(x => x.IdPracownika);

            builder.Entity<Pracownik>()
                .HasOne(x => x.Komis)
                .WithMany(x => x.Pracownicy)
                .HasForeignKey(x => x.IdKomisu);


            builder.Entity<Auto>()
                .HasKey(x => x.IdSamochodu);
               
            builder.Entity<Auto>()
                .HasOne(x => x.Sprzedaz)
                .WithMany(x => x.Auta)
                .HasForeignKey(x => x.IdSprzedazy);

            builder.Entity<Auto>()
               .HasOne(x => x.Komis)
               .WithMany(x => x.Auta)
               .HasForeignKey(x => x.IdKomisu);



            builder.Entity<Sprzedaz>()
                .HasKey(x => x.IdSprzedazy);

            builder.Entity<Sprzedaz>()
                 .HasOne(x => x.Klient)
                 .WithMany(x => x.Sprzedaze)
                 .HasForeignKey(x => x.IdKlienta);



            builder.Entity<Klient>()
              .HasKey(x => x.IdKlienta);


            base.OnModelCreating(builder);
        }


        public DbSet<Komis> Komis { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Sprzedaz> Sprzedaze { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Auto> Auta { get; set; }
    }
}
