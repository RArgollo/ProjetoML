using Microsoft.AspNetCore.Mvc;
using ProjetoML.lib.Data;
using ProjetoML.lib.Models;
using ProjetoML.lib.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace ProjetoML.web.Controllers;
[ApiController]
[Route("[controller]")]
public class VendedorController : ControllerBase
{
    public readonly VendedorRepositorio _repositorio;
    public VendedorController(VendedorRepositorio repositorio)
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
    public IActionResult Salvar(Vendedor vendedor)
    {
        _repositorio.Adicionar(vendedor);
        return Ok();
    }

    [HttpPut]
    public IActionResult AtualizarEmail(int id, string email)
    {
        _repositorio.AtualizarEmail(id, email);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}
