using Newtonsoft.Json;

namespace OngDonationApi.Models.Responses
{
    public class CepResponse
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }       
    }
}
