using ProjetoML.lib.Models;

namespace ProjetoML.lib.Data.Interfaces
{
    public interface ITransportadoraRepositorio : IRepositorioBase<Transportadora>
    {
        public void AtualizarTelefone(int id, string telefone);
    }
}