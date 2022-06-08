namespace ProjetoML.web.DTOs
{
    public class PedidoDTO
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual string Status { get; set; }
        public virtual int IdTransportadora { get; set; }
        public virtual int IdUsuario { get; set; }
    }
}