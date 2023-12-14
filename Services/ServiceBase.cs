using Crudblazorserve2.Interfaces;

namespace Crudblazorserve2.Services
{
    public class ServiceBase<T> : ICrud<T> where T : class
    {
        readonly ApplicationDbContext _context;
        protected IQueryable<T> Entities { get=>_context.Set<T>(); }

        public ServiceBase(ApplicationDbContext context)
        {
            this._context = context;
        }

        public bool Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                return _context.SaveChanges() !=0;
            }catch 
            {
                return false;
            }

        }

        public bool Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                return _context.SaveChanges() != 0;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                return _context.SaveChanges() != 0;
            }
            catch
            {
                return false;
            }
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
