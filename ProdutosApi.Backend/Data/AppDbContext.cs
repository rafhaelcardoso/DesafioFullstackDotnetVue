using Microsoft.EntityFrameworkCore;
using ProdutosApi.Backend.Mappings;
using ProdutosApi.Backend.Models;

namespace ProdutosApi.Backend.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=localhost,1433;Database=DBProdutos;User ID=sa;Password=Test@ndo2022");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProdutoMap());
    }
}
