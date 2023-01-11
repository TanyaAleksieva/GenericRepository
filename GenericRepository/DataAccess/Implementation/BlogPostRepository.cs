using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementation
{
    public class BlogPostRepository<T>: IRepository<T> where T: class
    {
        private Db_Context _context;
        private DbSet<T> table;

        public BlogPostRepository()
        {
            this._context = new Db_Context();
            table = _context.Set<T>();
        }
        public BlogPostRepository(Db_Context context)
        {
            this._context = context;
            table = _context.Set<T>();
        }

        public void Create(T entity)
        {
            table.Add(entity);
        }

        public void Delete(object id)
        {
            T e = table.Find(id);
            table.Remove(e);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
