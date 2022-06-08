using ProjetoML.lib.Models;
namespace ProjetoML.lib.Data.Repositorios
{
    public class TransportadoraRepositorio : RepositorioBase<Transportadora>
    {
        private readonly MLContext _context;
        public TransportadoraRepositorio(MLContext context) : base(context, context.Transportadoras)
        {
            _context = context;
        }
        public void AtualizarTelefone(int id, string telefone)
        {
            var transportadora = _context.Transportadoras.Find(id);
            transportadora.Telefone = telefone;
            _context.SaveChanges();
        }
    }
}