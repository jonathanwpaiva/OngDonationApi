using Newtonsoft.Json;

namespace OngDonationApi.Models.Responses
{
    public class CnpjResponse
    {
        [JsonProperty("uf")]
        public string State { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("natureza_juridica")]
        public string Natureza_juridica { get; set; }

        [JsonProperty("descricao_situacao_cadastral")]
        public string Descricao_situacao_cadastral { get; set; }

        [JsonProperty("municipio")]
        public string City { get; set; }

        [JsonProperty("razao_social")]
        public string Razao_social { get; set; }
    }
}
