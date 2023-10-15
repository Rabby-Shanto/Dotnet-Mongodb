using MongoDbSharp.Abstractions.BLL.Base;
using MongoDbSharp.Abstractions.Repository.Base;
using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;
using System.Linq.Expressions;

namespace MongoDbSharp.BLL.Base
{
    public abstract class Manager<T> : IManager<T> where T : class
    {
        private readonly IRepository<T> _repository;
        public Manager(IRepository<T> repository)
        {
            _repository = repository;

        }

        public bool Delete(T entity)
        {
            return _repository.Delete(entity);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(string id)
        {
            return _repository.GetById(id);
        }

        public bool Insert(T entity)
        {
            return _repository.Insert(entity);
        }

        public IList<T> SearchFor(FilterDto searchCriteria)
        {
            return _repository.SearchFor(searchCriteria);
        }

        //public IList<T> SearchFor(Expression<Func<T, bool>> predicate)
        //{
        //    return _repository.SearchFor(predicate);
        //}


        public bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
