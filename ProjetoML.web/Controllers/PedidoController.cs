using Microsoft.AspNetCore.Mvc;
using ProjetoML.lib.Data;
using ProjetoML.lib.Models;
using ProjetoML.lib.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace ProjetoML.web.Controllers;
[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{
    public readonly PedidoRepositorio _repositorio;
    public PedidoController(PedidoRepositorio repositorio)
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
    public IActionResult Salvar(Pedido pedido)
    {
        _repositorio.Adicionar(pedido);
        return Ok();
    }

    [HttpPut]
    public IActionResult AtualizarStatus(int id, string status)
    {
        _repositorio.AtualizarStatus(id, status);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}
