using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbSharp.Abstractions.Repository;
using MongoDbSharp.Model;
using MongoDbSharp.Repository.Base;

namespace MongoDbSharp.Repository
{
    public class EntityRepository : MongoRepository<EntityModel>,IEntityRepository
    {
        private readonly IMongoCollection<EntityModel> _db;

        public EntityRepository(IOptions<DbModel> mongoDBSettings) : base(mongoDBSettings)
        {
        }
    }
}
