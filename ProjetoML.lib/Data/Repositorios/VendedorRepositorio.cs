using ProjetoML.lib.Data.Interfaces;
using ProjetoML.lib.Models;
namespace ProjetoML.lib.Data.Repositorios
{
    public class VendedorRepositorio : RepositorioBase<Vendedor>, IRepositorioBase<Vendedor>
    {
        private readonly MLContext _context;
        public VendedorRepositorio(MLContext context) : base(context, context.Vendedores)
        {
            _context = context;
        }
        public void AtualizarEmail(int id, string email)
        {
            var vendedor = _context.Vendedores.Find(id);
            vendedor.Email = email;
            _context.SaveChanges();
        }
    }
}