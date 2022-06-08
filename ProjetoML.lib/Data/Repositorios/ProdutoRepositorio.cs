using ProjetoML.lib.Models;
namespace ProjetoML.lib.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>
    {
        private readonly MLContext _context;
        public ProdutoRepositorio(MLContext context) : base(context, context.Produtos)
        {
            _context = context;
        }
        public void AtualizarDescricao(int id, string descricao)
        {
            var produto = _context.Produtos.Find(id);
            produto.Descricao = descricao;
            _context.SaveChanges();
        }
    }
}