using ClienteWebApi.Models;
using MongoDB.Driver;

namespace ClienteWebApi
{
    public interface IClienteContext
    {
        IMongoCollection<Cliente> Cliente { get; }
    }
}
