using Microsoft.EntityFrameworkCore;
namespace ProjetoML.lib.Data.Repositorios
{
    public class RepositorioBase<T> where T : class
    {
        private readonly MLContext _context;
        private readonly DbSet<T> _dbset;
        public RepositorioBase(MLContext context, DbSet<T> dbset)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> BuscarTodos()
        {
            return _dbset.AsNoTracking().ToList();
        }

        public T BuscarPorId(int id)
        {
            return _dbset.Find(id);
        }

        public void Adicionar(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var item = _dbset.Find(id);
            _dbset.Remove(item);
            _context.SaveChanges();
        }
    }
}