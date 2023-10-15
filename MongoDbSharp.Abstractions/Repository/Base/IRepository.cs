using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;

namespace MongoDbSharp.Abstractions.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        //IList<T> SearchFor(Expression<Func<T, bool>> predicate);
        IList<T> SearchFor(FilterDto searchCriteria);
        IList<T> GetAll();
        T GetById(string id);
    }
}
