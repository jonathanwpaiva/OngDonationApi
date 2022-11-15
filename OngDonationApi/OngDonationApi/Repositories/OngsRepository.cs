using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using OngDonationApi.Models;
using OngDonationApi.Models.UI;
using OngDonationApi.Repositories.Interfaces;

namespace OngDonationApi.Repositories
{
    public class OngsRepository : IOngsRepository
    {
        private readonly IMongoCollection<Ong> _ongCollection;        

        public OngsRepository(ApiSettings apiSettings)
        {
            MongoClient client = new MongoClient(apiSettings.MongoDbSettings.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(apiSettings.MongoDbSettings.DatabaseName);
            _ongCollection = database.GetCollection<Ong>(apiSettings.MongoDbSettings.CollectionName);

        }

        public async Task<IEnumerable<Ong>> GetOngs()
        {
            return await _ongCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task CreateOng(Ong ong)
        {
            await _ongCollection.InsertOneAsync(ong);
            return;
        }       

        public async Task DeleteOng(string id)
        {
            FilterDefinition<Ong> filter = Builders<Ong>.Filter.Eq("Id", id);
            await _ongCollection.DeleteOneAsync(filter);
            return;
        }
    }
}
