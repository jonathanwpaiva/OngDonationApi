using Newtonsoft.Json;

namespace OngDonationApi.Models.UI
{
    public class MongoDbSettings
    {
        [JsonProperty("connectionURI")]
        public string ConnectionURI { get; set; }

        [JsonProperty("databaseName")]
        public string DatabaseName { get; set; }

        [JsonProperty("collectionName")]
        public string CollectionName { get; set; }
    }
}
