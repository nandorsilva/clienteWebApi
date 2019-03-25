using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClienteWebApi.Models
{
    public class Cliente
    {
        [BsonId]
        public ObjectId InternalId { get; set; }       
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
