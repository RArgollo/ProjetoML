using ProjetoML.lib.Models;

namespace ProjetoML.lib.Data.Interfaces
{
    public interface IVendedorRepositorio : IRepositorioBase<Vendedor>
    {
        public void AtualizarEmail(int id, string email);
    }
}