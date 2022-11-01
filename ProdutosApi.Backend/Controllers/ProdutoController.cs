using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutosApi.Backend.Data;
using ProdutosApi.Backend.Models;
using ProdutosApi.Backend.Models.ViewModel;

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
}
