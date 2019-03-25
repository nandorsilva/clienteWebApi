using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClienteWebApi.Models
{
        public interface IClienteRepository
        {
            Task<Cliente> Buscar(string id);
            Task Criar(Cliente cliente);
        }
}
