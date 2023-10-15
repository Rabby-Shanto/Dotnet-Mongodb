using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbSharp.Abstractions.Repository.Base;
using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;

namespace MongoDbSharp.Repository.Base
{
    public abstract class MongoRepository<T> : IRepository<T> where T : EntityModel
    {
        private readonly IMongoCollection<T> _db;
        public MongoRepository(IOptions<DbModel> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _db = database.GetCollection<T>(mongoDBSettings.Value.CollectionName);
        }

        public bool Delete(T entity)

        {
            var filter = Builders<T>.Filter.Eq("_id", entity.Id);
            return _db.DeleteOne(filter).DeletedCount > 0;
        }

        public IList<T> GetAll()
        {
            return _db.Find(new BsonDocument()).ToList();
        }

        public T GetById(string id)
        {
            return _db.Find(Builders<T>.Filter.Eq("_id", id)).FirstOrDefault();
        }


        public bool Insert(T entity)
        {
            _db.InsertOne(entity);
            return true;
        }

        public IList<T> SearchFor(FilterDto searchCriteria)
        {
            IQueryable<T> query = _db.AsQueryable<T>();

            if (!string.IsNullOrEmpty(searchCriteria.Name))
            {
                query = query.Where(entity => entity.Name.Contains(searchCriteria.Name));
            }

            if (!string.IsNullOrEmpty(searchCriteria.InstituteName))
            {
                query = query.Where(entity => entity.InstituteName == searchCriteria.InstituteName);
            }

            if (!string.IsNullOrEmpty(searchCriteria.Gender))
            {
                query = query.Where(entity => entity.Gender == searchCriteria.Gender);
            }

            return query.ToList();
        }

        public bool Update(T entity)
        {
            if (entity.Id == null)
                return Insert(entity);

            var filter = Builders<T>.Filter.Eq("_id", entity.Id);

            return _db.ReplaceOne(filter, entity).ModifiedCount > 0;
        }
    }


    //public IList<T> SearchFor(Expression<Func<T, bool>> predicate)
    //{
    //    //return _db.AsQueryable<T>().Where(predicate.Compile()).ToList();
    //    FilterDefinition<T> filterDefinition = Builders<T>.Filter.Where(predicate);
    //    return _db.Find(filterDefinition).ToList();
    //}

}
