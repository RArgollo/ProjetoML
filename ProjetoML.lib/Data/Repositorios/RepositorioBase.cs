using Microsoft.EntityFrameworkCore;
using ProjetoML.lib.Data.Interfaces;
using ProjetoML.lib.Models;

namespace ProjetoML.lib.Data.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : ModelBase
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
            return _dbset.AsNoTracking().First(x => x.Id == id);
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