using MongoDB.Bson.Serialization.Attributes;
using MongoDbSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbSharp.Abstractions.Repository.Base
{
    public interface IRepository<T> where T: EntityModel
    {
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IList<T> SearchFor(Expression<Func<T, bool>> predicate);
        IList<T> GetAll();
        T GetById(string id);
    }
}
