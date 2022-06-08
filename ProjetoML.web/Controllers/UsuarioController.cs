using Microsoft.AspNetCore.Mvc;
using ProjetoML.lib.Data;
using ProjetoML.lib.Models;
using ProjetoML.lib.Data.Repositorios;
using Microsoft.EntityFrameworkCore;
namespace ProjetoML.web.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    public readonly UsuarioRepositorio _repositorio;
    public UsuarioController(UsuarioRepositorio repositorio)
    {
        _repositorio = repositorio;
    }
    [HttpGet]
    public IActionResult GetTodos()
    {
        return Ok(_repositorio.BuscarTodos);
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        return Ok(_repositorio.BuscarPorId(id));
    }

    [HttpPost]
    public IActionResult Salvar(Usuario usuario)
    {
        _repositorio.Adicionar(usuario);
        return Ok();
    }

    [HttpPut]
    public IActionResult AtualizarSenha(int id, string senha)
    {
        _repositorio.AtualizarSenha(id, senha);
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeletePorId(int id)
    {
        _repositorio.Deletar(id);
        return Ok();
    }
}