using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteWebApi.Models
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IClienteContext _context;

        public ClienteRepository(IClienteContext context)
        {
            _context = context;
        }       

        public Task<Cliente> Buscar(string id)
        {
            var _id = ObjectId.Parse(id);
            FilterDefinition<Cliente> filter = Builders<Cliente>.Filter.Eq(m => m.InternalId, _id);
            return _context
                    .Cliente
                    .Find(filter)
                    .FirstOrDefaultAsync();
        }
        
        public async Task Criar(Cliente cliente)
        {
            await _context.Cliente.InsertOneAsync(cliente);
        }
    }
}
