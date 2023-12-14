namespace Crudblazorserve2.Interfaces
{
    public interface ICrud<T> where T : class
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
