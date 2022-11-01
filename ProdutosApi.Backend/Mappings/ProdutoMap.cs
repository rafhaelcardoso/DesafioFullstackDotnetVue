using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProdutosApi.Backend.Models;

namespace ProdutosApi.Backend.Mappings;

public class ProdutoMap : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        //Definindo Tabela
        builder.ToTable("Produtos");

        //Primary Key  e Identity
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();

        //Nome
        builder.Property(p => p.Titulo)
               .IsRequired()
               .HasColumnName("Titulo")
               .HasColumnType("Varchar")
               .HasMaxLength(30);
        //Descricao
        builder.Property(p => p.Descricao)
               .HasColumnName("Descricao")
               .HasColumnType("Varchar")
               .HasMaxLength(1000);
        //Valor
        builder.Property(p => p.Valor)
               .HasColumnName("Valor")
               .HasColumnType("numeric(18,2)")
               .IsRequired();
        //Imagem
        builder.Property(p => p.Imagem)
               .IsRequired()
               .HasColumnName("Imagem");
        //DataCriacao
        builder.Property(p => p.DataCriacao)
               .IsRequired()
               .HasColumnName("DataCriacao")
               .HasColumnType("SmallDateTime")
               .HasMaxLength(60);
        //DataEdicao
        builder.Property(p => p.DataEdicao)
               .HasColumnName("DataEdicao")
               .HasColumnType("SmallDateTime")
               .HasMaxLength(60);
    }
}
