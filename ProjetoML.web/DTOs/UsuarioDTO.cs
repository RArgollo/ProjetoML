namespace ProjetoML.web.DTOs
{
    public class UsuarioDTO
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string CPF { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Senha { get; set; }
    }
}