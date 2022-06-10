namespace ProjetoML.lib.Models
{
    public class Transportadora : ModelBase
    {
        public virtual string Nome { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Email { get; set; }
        public virtual List<Pedido>? Pedidos { get; set; }

        public Transportadora(int id, string nome, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
        public Transportadora()
        {
            
        }
    }
}