using ProjetoML.lib.Data.Interfaces;
using ProjetoML.lib.Models;
namespace ProjetoML.lib.Data.Repositorios
{
    public class PedidoRepositorio : RepositorioBase<Pedido>, IRepositorioBase<Pedido>
    {
        private readonly MLContext _context;
        public PedidoRepositorio(MLContext context): base(context, context.Pedidos)
        {
            _context = context;
        }
      
        public void AtualizarStatus(int id, string status)
        {
            var pedido = _context.Pedidos.Find(id);
            pedido.Status = status;
            _context.SaveChanges();
        }
    }
}