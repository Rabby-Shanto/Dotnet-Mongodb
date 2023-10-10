using MongoDbSharp.Model;
using System.Linq.Expressions;

namespace MongoDbSharp.Abstractions.BLL.Base
{
    public interface IManager<T> where T : EntityModel
    {
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IList<T> SearchFor(Expression<Func<T, bool>> predicate);
        IList<T> GetAll();
        T GetById(string id);
    }
}
