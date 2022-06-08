namespace ProjetoML.lib.Models
{
    public class ProdutosXPedidos
    {
        public virtual int Id { get; set; }
        public virtual int IdProduto { get; set; }
        public virtual int IdPedido { get; set; }
        public virtual Pedido? Pedido { get; set; }
        public virtual Produto? Produto { get; set; }

        public ProdutosXPedidos(int id, int idProduto, int idPedido)
        {
            Id = id;
            IdProduto = idProduto;
            IdPedido = idPedido;
        }
        public ProdutosXPedidos()
        {
            
        }
    }
}