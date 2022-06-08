using Microsoft.AspNetCore.Mvc;
using ProjetoML.lib.Data;
using ProjetoML.lib.Models;
using ProjetoML.lib.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace ProjetoML.web.Controllers;
[ApiController]
[Route("[controller]")]
public class TransportadoraController : ControllerBase
{
    public readonly TransportadoraRepositorio _repositorio;
    public TransportadoraController(TransportadoraRepositorio repositorio)
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
    public IActionResult Salvar(Transportadora transportadora)
    {
        _repositorio.Adicionar(transportadora);
        return Ok();
    }

    [HttpPut]
    public IActionResult AtualizarTelefone(int id, string telefone)
    {
        _repositorio.AtualizarTelefone(id, telefone);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}
