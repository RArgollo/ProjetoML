namespace ProjetoML.lib.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdVendedor { get; set; }
        public Vendedor? Vendedor { get; set; }
        public virtual List<ProdutosXPedidos> ListaProdutosXPedidos { get; set; }

        public Produto(int id, string nome, string descricao, double valor, string dataCadastro, int idVendedor)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = DateTime.Parse(dataCadastro);
            IdVendedor = idVendedor;
        }
        public Produto()
        {
            
        }
    }
}