using MongoDB.Bson.Serialization.Attributes;

namespace OngDonationApi.Models
{
    public class Ong
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Uf { get; set; }
        public string Municipio { get; set; }
        public string Natureza_juridica { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
