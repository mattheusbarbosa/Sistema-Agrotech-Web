using Agrotechteste.Models;
using Microsoft.EntityFrameworkCore;

namespace Agrotechteste.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

       
        public DbSet<Usuario> Usuarios { get; set; }
        
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Insumo> Insumo { get; set; }
        public DbSet<Lotes_Insumo> Lotes_Insumos { get; set; }
        public DbSet<Lotes> Lotes { get; set; }
        public DbSet<item_Venda> ItemVendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
           

            
            modelBuilder.Entity<Usuario>().HasKey(u => u.idUsuario);
            modelBuilder.Entity<Usuario>().ToTable("usuario");

           
            modelBuilder.Entity<Produto>().HasKey(p => p.ID_Produto);
            modelBuilder.Entity<Produto>().ToTable("Produtos");

           
            modelBuilder.Entity<Insumo>().HasKey(i => i.ID_Insumo);
            modelBuilder.Entity<Insumo>().ToTable("Insumos");

            
            modelBuilder.Entity<Lotes_Insumo>().HasKey(li => li.ID_Lote);
            modelBuilder.Entity<Lotes_Insumo>()
                .HasOne(li => li.Insumo)
                .WithMany(i => i.Lotes)
                .HasForeignKey(li => li.ID_Insumo)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Lotes_Insumo>().ToTable("Lotes_Insumo");

            
            modelBuilder.Entity<Lotes>().HasKey(l => l.ID_Lote);
            modelBuilder.Entity<Lotes>()
                .HasOne(l => l.Produto)
                .WithMany(p => p.Lotes)
                .HasForeignKey(l => l.ID_Produto)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Lotes>().ToTable("Lotes");

         
            modelBuilder.Entity<item_Venda>().HasKey(iv => iv.id_Item_Venda);
            modelBuilder.Entity<item_Venda>().ToTable("item_venda");
        }
    }
}
