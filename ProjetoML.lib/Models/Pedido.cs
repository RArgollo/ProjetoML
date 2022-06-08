namespace ProjetoML.lib.Models
{
    public class Pedido
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual string Status { get; set; }
        public virtual int IdTransportadora { get; set; }
        public virtual int IdUsuario { get; private set; }
        public virtual Transportadora? Transportadora { get; set; }
        public virtual Usuario? Usuario { get; set; }
        public virtual List<ProdutosXPedidos> ListaProdutosXPedidos { get; set; }

        public Pedido(int id, string dataPedido, string status, int idTransportadora, int IdUsuario)
        {
            Id = id;
            DataPedido = DateTime.Parse(dataPedido);
            Status = status;
            IdTransportadora = idTransportadora;
            IdUsuario = IdUsuario;
        }
        public Pedido()
        {
            
        }
    }
}