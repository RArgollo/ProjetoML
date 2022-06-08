using Microsoft.AspNetCore.Mvc;
using ProjetoML.lib.Data;
using ProjetoML.lib.Models;
using ProjetoML.lib.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace ProjetoML.web.Controllers;
[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    public readonly ProdutoRepositorio _repositorio;
    public ProdutoController(ProdutoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }
    [HttpGet]
    public IActionResult GetTodos()
    {
        return Ok(_repositorio.BuscarTodos());
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        return Ok(_repositorio.BuscarPorId(id));
    }

    [HttpPost]
    public IActionResult Adicionar(Produto produto)
    {
        _repositorio.Adicionar(produto);
        return Ok();
    }

    [HttpPut]
    public IActionResult AtualizarDescricao(int id, string descricao)
    {
        _repositorio.AtualizarDescricao(id, descricao);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}
