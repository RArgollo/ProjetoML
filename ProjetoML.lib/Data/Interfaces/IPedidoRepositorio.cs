using ProjetoML.lib.Models;

namespace ProjetoML.lib.Data.Interfaces
{
    public interface IPedidoRepositorio : IRepositorioBase<Pedido>
    {
        public void AtualizarStatus(int id, string status);
    }
}