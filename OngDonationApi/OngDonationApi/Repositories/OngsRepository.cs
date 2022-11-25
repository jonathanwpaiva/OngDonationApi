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

        public async Task<IEnumerable<Ong>> GetOngByCnpj(string cnpj)
        {
            var ongs =  await _ongCollection.Find(new BsonDocument()).ToListAsync();
            var ong = ongs.Where((ong) => ong.Cnpj == cnpj);
            return ong;
        }

        public async Task<IEnumerable<Ong>> GetOngByCity(string city)
        {
            var cityNormalized = ExtensionsMethods.removeSpecialCharacter(city).ToUpper();
            var ongs = await _ongCollection.Find(new BsonDocument()).ToListAsync();
            var ongInThisCity = ongs.Where((ong) => ong.Municipio == cityNormalized);
            return ongInThisCity;
        }

    }
}
