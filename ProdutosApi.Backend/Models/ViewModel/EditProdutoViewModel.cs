using System.ComponentModel.DataAnnotations;

namespace ProdutosApi.Backend.Models.ViewModel;

public class EditProdutoViewModel
{
    [Required(ErrorMessage = "O Titulo é obrigatório.")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "O Titulo deve ter entre 3 e 40 caracteres.")]
    public string Titulo { get; set; }

    [StringLength(1000, ErrorMessage = "A descrição pode conter até 1000 caracteres.")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o valor do produto para cadastrar.")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "É obrigatório informar a imagem do produto.")]
    public string Imagem { get; set; }
    public DateTime DataEdicao { get; set; } = DateTime.Now;
}
