namespace ProjetoML.web.DTOs
{
    public class ProdutosXPedidosDTO
    {
         public virtual int Id { get; set; }
        public virtual int IdProduto { get; set; }
        public virtual int IdPedido { get; set; }
    }
}