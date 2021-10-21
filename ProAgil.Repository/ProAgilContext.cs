using Microsoft.EntityFrameworkCore;
using ProAgil.Domain;

namespace ProAgil.Repository
{
    public class ProAgilContext : DbContext
    {
        

        public DbSet<Evento> Eventos { get; set;}
        public DbSet<Lote> Lotes { get; set;}
        public DbSet<Palestrante> Palestrantes { get; set;}
        public DbSet<PalestranteEvento> PalestrantesEventos { get; set;}
        public DbSet<RedeSocial> RedeSociais { get; set;}
      
      protected override void OnConfiguring(DbContextOptionsBuilder options)
      {
          if (!options.IsConfigured)
          {
              options.UseSqlServer("Data Source=DESKTOP-869FBIF\\SQLEXPRESS;Integrated Security=True;Database=ProAgilDB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
          }
      }
      protected override void OnModelCreating(ModelBuilder modelBuilder){
          modelBuilder.Entity<PalestranteEvento>()
          .HasKey(PE => new { PE.EventoId, PE.PalestranteId});
      }
    }
}