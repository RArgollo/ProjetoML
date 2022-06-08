namespace ProjetoML.web.DTOs
{
    public class VendedorDTO
    {
         public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual DateTime DataCadastro { get; set; }
    }
}