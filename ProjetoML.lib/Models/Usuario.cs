namespace ProjetoML.lib.Models
{
    public class Usuario : ModelBase
    {
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string CPF { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Senha { get; set; }
        public virtual List<Pedido>? Pedidos { get; set; }

        public Usuario(int id, string nome, string email, string cpf, string dataNascimento, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
            DataNascimento = DateTime.Parse(dataNascimento);
            Senha = senha;
        }
        public Usuario()
        {

        }
    }
}