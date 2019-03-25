using ClienteWebApi.Models;
using MongoDB.Driver;

namespace ClienteWebApi
{
    public class ClienteContext:IClienteContext
    {
        private readonly IMongoDatabase _db;
        public IMongoCollection<Cliente> Cliente => _db.GetCollection<Cliente>("Cliente");
  

        public ClienteContext(MongoDbConfig config)
        {
            var client = new MongoClient(config.Server);
            _db = client.GetDatabase(config.DataBase);
        }      
        
    }
}

