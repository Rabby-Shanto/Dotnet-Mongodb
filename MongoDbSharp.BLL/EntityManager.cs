using MongoDbSharp.Abstractions.BLL;
using MongoDbSharp.Abstractions.Repository;
using MongoDbSharp.BLL.Base;
using MongoDbSharp.Model;

namespace MongoDbSharp.BLL
{
    public class EntityManager : Manager<EntityModel>,IEntity
    {
        private readonly IEntityRepository _repository;
        public EntityManager(IEntityRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }

}
