using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace APICatalogo.Context
{
    public class AppDbContext : DbContext
    {
        public  AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {}

        public DbSet<Categorias> Categorias {  get; set; }
        public DbSet <Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>().ToTable("categorias")
                .HasKey(e => e.CategoriaId);

            modelBuilder.Entity<Produto>().ToTable("produtos").HasOne<Categorias>(s => s.Categorias)
            .WithMany(g => g.Produtos)
            .HasForeignKey(s => s.CategoriaId);
              
           modelBuilder.Entity<Produto>().HasKey(e => e.ProdutoId);

                
        }

     }
}
