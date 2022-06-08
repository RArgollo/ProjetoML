namespace ProjetoML.lib.Models
{
    public class Vendedor
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual DateTime DataCadastro { get; set; }
        public virtual List<Produto>? Produtos { get; set; }

        public Vendedor(int id, string nome, string email, string cnpj, string dataCadastro)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CNPJ = cnpj;
            DataCadastro = DateTime.Parse(dataCadastro);
        }
        public Vendedor()
        {
            
        }
    }
}