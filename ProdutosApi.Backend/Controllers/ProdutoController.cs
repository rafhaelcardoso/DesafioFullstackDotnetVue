using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutosApi.Backend.Data;
using ProdutosApi.Backend.Models;
using ProdutosApi.Backend.Models.ViewModel;
using System.Text.RegularExpressions;

namespace ProdutosApi.Backend.Controllers;

[ApiController]
public class ProdutoController : ControllerBase
{
    private AppDbContext _context;

    public ProdutoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("api/produtos/{skip:int}/{take:int}")]
    public async Task<IActionResult> GetProdutosAsync([FromServices] AppDbContext context, [FromQuery] string? s, int skip = 0, int take = 5)
    {
        if (!String.IsNullOrEmpty(s))
        {
            var pesquisa = await _context.Produtos.AsNoTracking().Where(p => p.Titulo.Contains(s) || p.Descricao.Contains(s)).ToListAsync();
            return Ok(new Result<List<Produto>>(pesquisa));
        }

        var produtos = await _context.Produtos.AsNoTracking().ToListAsync();
        return Ok(new Result<List<Produto>>(produtos));
    }

    [HttpGet]
    [Route("api/produtos/{id:int}")]
    public async Task<IActionResult> GetProdutosPorIdAsync([FromRoute] int id)
    {
        var produto = await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

        if (produto is null)
            return NotFound(new Result<Produto>($"Não foi encontrado um produto com o id = {id}."));

        return Ok(new Result<Produto>(produto));
    }

    [HttpPost]
    [Route("api/produtos")]
    public async Task<IActionResult> PostProdutoAsync([FromBody] AddProdutoViewModel produtoModel)
    {
        var fileName = $"{Guid.NewGuid().ToString()}.jpg";
        var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(produtoModel.Imagem, "");
        var bytes = Convert.FromBase64String(data);

        await System.IO.File.WriteAllBytesAsync($"wwwroot/Images/{fileName}", bytes);

        var produto = new Produto
        {
            Id = 0,
            Titulo = produtoModel.Titulo,
            Descricao = produtoModel.Descricao,
            Valor = produtoModel.Valor,
            Imagem = $"https://localhost:7181/Images/{fileName}",
            DataCriacao = DateTime.Now,
            DataEdicao = DateTime.Now
        };

        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();

        return Created($"api/produtos/{produto.Id}", new Result<Produto>(produto));
    }

    [HttpPut]
    [Route("api/produtos/{id:int}")]
    public async Task<IActionResult> PutProdutoAsync([FromRoute] int id, [FromBody] EditProdutoViewModel produtoModel)
    {
        var produto = await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

        if (produto is null)
            return NotFound(new Result<Produto>($"Não foi encontrado um produto com o id = {id}."));

        if (produto is null)
            return NotFound(new Result<Produto>($"Não foi encontrado um produto com o id = {id}."));

        var fileName = $"{Guid.NewGuid().ToString()}.jpg";
        var data = new Regex(@"^data:image\/[a-z]+;base64,").Replace(produtoModel.Imagem, "");
        var bytes = Convert.FromBase64String(data);

        await System.IO.File.WriteAllBytesAsync($"wwwroot/Images/{fileName}", bytes);

        produto.Titulo = produtoModel.Titulo;
        produto.Descricao = produtoModel.Descricao;
        produto.Valor = produtoModel.Valor;
        produto.Imagem = $"https://localhost:7181/Images/{fileName}";
        produto.DataEdicao = DateTime.Now;

        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();
        return Ok(new Result<Produto>(produto));
    }

    [HttpDelete]
    [Route("api/produtos/{id:int}")]
    public async Task<IActionResult> DeleteProdutoAsync([FromRoute] int id)
    {
        var produto = await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

        if (produto is null)
            return NotFound(new Result<Produto>($"Não foi encontrado um produto com o id = {id}."));

        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();

        return Ok(new Result<Produto>(produto));
    }

}
