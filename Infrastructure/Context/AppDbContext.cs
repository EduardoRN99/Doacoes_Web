using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public  class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Doador_Empresa> DoadoresEmpresa { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Doacao>()
                .HasOne(a => a.Doador)
                .WithMany()
                .HasForeignKey(a => a.DoadorId)
                .OnDelete(DeleteBehavior.SetNull);

            
            modelBuilder.Entity<Doacao>()
                .HasOne<Doador_Empresa>()
                .WithMany()
                .HasForeignKey("DoadorEmpresaId")
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
