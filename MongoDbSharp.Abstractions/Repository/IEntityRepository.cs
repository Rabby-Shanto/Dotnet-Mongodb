using MongoDbSharp.Abstractions.Repository.Base;
using MongoDbSharp.Model;

namespace MongoDbSharp.Abstractions.Repository
{
    public interface IEntityRepository : IRepository<EntityModel>
    {
    }
}
