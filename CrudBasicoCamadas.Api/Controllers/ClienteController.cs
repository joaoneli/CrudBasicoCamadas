using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route ("Cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteServices;
        public ClienteController(IClienteService clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet]
        public ActionResult<List<ClienteEntity>> GetAll()
        {

            var clientes = _clienteServices.GetAll();
            if (clientes == null)
            {
                return NotFound("Nenhum cliente encontrado!");
            }
            return Ok(clientes);
        }

        [HttpGet]
        [Route("GetById")]

        public ActionResult<ClienteEntity> GetById([FromHeader] ClienteEntity cliente)
        {
            var clientes = _clienteServices.GetById(cliente.Id);

            if (clientes == null)
            {
                return NotFound("Nenhum cliente encontrado!");
            }
            return Ok(clientes);
        }

        [HttpDelete]
        public ActionResult<ClienteEntity> DeleteById([FromHeader] ClienteEntity cliente)
        {
            var clienteDelete = _clienteServices.DeleteById(cliente);

            if (!clienteDelete)
            {
                return BadRequest("Erro ao deletar cliente!");
            }
            return Ok(clienteDelete);
        }

        [HttpPost]
        public ActionResult<ClienteEntity> Insert([FromBody] ClienteEntity cliente)
        {
            var insertCliente = _clienteServices.Insert(cliente);

            if (!insertCliente)
            {
                return BadRequest("Erro ao salvar cliente!");
            }
            return Ok(insertCliente);
        }

        [HttpPut]
        public ActionResult<ClienteEntity> Update([FromBody] ClienteEntity cliente)
        {
            var updateCliente = _clienteServices.Update(cliente);

            if (!updateCliente)
            {
                return BadRequest("Erro ao inserir cliente!");
            }
            return Ok(updateCliente);
        }
    }
}
