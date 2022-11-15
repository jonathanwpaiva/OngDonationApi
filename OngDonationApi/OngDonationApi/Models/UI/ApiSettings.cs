using Newtonsoft.Json;

namespace OngDonationApi.Models.UI
{
    public class ApiSettings
    {
        [JsonProperty("brasilApiBaseUrl")]
        public string BrasilApiBaseUrl { get; set; }

        [JsonProperty("mongoDbSettings")]
        public MongoDbSettings MongoDbSettings { get; set; }
    }
}
