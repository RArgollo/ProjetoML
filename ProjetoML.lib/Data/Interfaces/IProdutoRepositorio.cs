using ProjetoML.lib.Models;

namespace ProjetoML.lib.Data.Interfaces
{
    public interface IProdutoRepositorio : IRepositorioBase<Produto>
    {
        public void AtualizarDescricao(int id, string descricao);
    }
}