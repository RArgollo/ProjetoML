using ProjetoML.lib.Models;

namespace ProjetoML.lib.Data.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        public void AtualizarSenha(int id, string senha);
    }
}