using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDbSharp.Abstractions.Repository.Base;
using MongoDbSharp.Model;
using MongoDbSharp.Model.DTO;

namespace MongoDbSharp.Repository.Base
{
    public abstract class MongoRepository<T> : IRepository<T> where T : class
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
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty == null)
                throw new InvalidOperationException("Type does not have an 'Id' property.");

            var idValue = idProperty.GetValue(entity);
            var filter = Builders<T>.Filter.Eq("_id", idValue);
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
            var filterBuilder = Builders<T>.Filter;
            FilterDefinition<T> filter = filterBuilder.Empty;
            foreach (var property in typeof(FilterDto).GetProperties())
            {
                var value = property.GetValue(searchCriteria);

                if (value != null)
                {
                    filter &= filterBuilder.Eq(property.Name, value);
                }
            }

            return _db.Find(filter).ToList();
        }


        public bool Update(T entity)
        {
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty == null)
                throw new InvalidOperationException("Type does not have an 'Id' property.");

            var idValue = idProperty.GetValue(entity);
            if (idValue == null)
                throw new InvalidOperationException("Entity does not have a value for 'Id' property.");

            var filter = Builders<T>.Filter.Eq("_id", idValue);
            return _db.ReplaceOne(filter, entity).ModifiedCount > 0;
        }
    }


}
