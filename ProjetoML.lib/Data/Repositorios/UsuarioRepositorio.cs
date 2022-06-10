using ProjetoML.lib.Data.Interfaces;
using ProjetoML.lib.Models;
namespace ProjetoML.lib.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IRepositorioBase<Usuario>
    {
        private readonly MLContext _context;
        public UsuarioRepositorio(MLContext context) : base(context, context.Usuarios)
        {
            _context = context;
        }

        public void AtualizarSenha(int id, string senha)
        {
            var usuario = _context.Usuarios.Find(id);
            usuario.Senha = senha;
            _context.SaveChanges();
        }

    }
}