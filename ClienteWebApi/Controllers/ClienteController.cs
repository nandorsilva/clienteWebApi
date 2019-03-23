using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClienteWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClienteWebApi.Controllers
{
    [Route("api/[Controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repo;

        public ClienteController(IClienteRepository repo)
        {
            _repo = repo;
        }
      

        // GET api/clientes/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> Get(string id)
        {
            var cliente = await _repo.Buscar(id);
            if (cliente == null)
                return new NotFoundResult();

            return new ObjectResult(cliente);
        }

        // POST api/cliente
        [HttpPost]
        public async Task<ActionResult<Cliente>> Post([FromBody] Cliente cliente)
        {
            //todo.Id = await _repo.GetNextId();
            await _repo.Criar(cliente);
            return new OkObjectResult(cliente);
        }
    }
}