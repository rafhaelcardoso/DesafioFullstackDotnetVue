namespace ProdutosApi.Backend.Models;

public class Produto
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public string Imagem { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataEdicao { get; set; }
}
