using Microsoft.EntityFrameworkCore;
using ProjetoML.lib.Models;
namespace ProjetoML.lib.Data
{
    public class MLContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutosXPedidos> ProdutosXPedidos { get; set; }
        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public MLContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Pedidos
            modelBuilder.Entity<Pedido>().ToTable("ml_pedidos");
            modelBuilder.Entity<Pedido>().HasKey(x => x.Id);
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Transportadora)
                        .WithMany(x => x.Pedidos)
                        .HasForeignKey(x => x.IdTransportadora);
            modelBuilder.Entity<Pedido>()
                        .HasOne(x => x.Usuario)
                        .WithMany(x => x.Pedidos)
                        .HasForeignKey(x => x.IdUsuario);
            //Produtos
            modelBuilder.Entity<Produto>().ToTable("ml_produtos");
            modelBuilder.Entity<Produto>().HasKey(x => x.Id);
            modelBuilder.Entity<Produto>()
                        .HasOne(x => x.Vendedor)
                        .WithMany(x => x.Produtos)
                        .HasForeignKey(x => x.IdVendedor);
            //ProdutosXPedidos
            modelBuilder.Entity<ProdutosXPedidos>().ToTable("ml_pedidos_x_produtos");
            modelBuilder.Entity<ProdutosXPedidos>().HasKey(x => x.Id);
            modelBuilder.Entity<ProdutosXPedidos>()
                        .HasOne(x => x.Pedido)
                        .WithMany(x => x.ListaProdutosXPedidos)
                        .HasForeignKey(x => x.IdPedido);
            modelBuilder.Entity<ProdutosXPedidos>()
                        .HasOne(x => x.Produto)
                        .WithMany(x => x.ListaProdutosXPedidos)
                        .HasForeignKey(x => x.IdProduto);
            //Transportadoras
            modelBuilder.Entity<Transportadora>().ToTable("ml_transportadoras");
            modelBuilder.Entity<Transportadora>().HasKey(x => x.Id);
            modelBuilder.Entity<Transportadora>()
                        .HasMany(x => x.Pedidos)
                        .WithOne(x => x.Transportadora)
                        .HasForeignKey(x => x.IdTransportadora);
            //Usuarios
            modelBuilder.Entity<Usuario>().ToTable("ml_usuarios");
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuario>()
                        .HasMany(x => x.Pedidos)
                        .WithOne(x => x.Usuario)
                        .HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Usuario>().Property(x=> x.Id).HasColumnName("id");
            //Vendedores
            modelBuilder.Entity<Vendedor>().ToTable("ml_vendedores");
            modelBuilder.Entity<Vendedor>().HasKey(x => x.Id);
            modelBuilder.Entity<Vendedor>()
                        .HasMany(x => x.Produtos)
                        .WithOne(x => x.Vendedor)
                        .HasForeignKey(x => x.IdVendedor);
        }
    }
}