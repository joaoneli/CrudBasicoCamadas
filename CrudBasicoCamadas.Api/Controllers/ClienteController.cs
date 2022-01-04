using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route ("Cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteServices;
        const string _swaggerName = "Clientes";

        public ClienteController(IClienteService clienteServices)
        {
            _clienteServices = clienteServices;
        }


        /// <summary>
        /// Busca todos os Clientes
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="200">Ok</response>
        [SwaggerOperation(Tags = new[] { _swaggerName })]
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

        /// <summary>
        /// Busca Cliente por Id
        /// Retorna informações do cliente   
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        [SwaggerOperation(Tags = new[] { _swaggerName })]
        [HttpGet]
        [Route("GetById")]
        [ProducesResponseType(typeof(ClienteEntity), StatusCodes.Status200OK)]
        public ActionResult<ClienteEntity> GetById([FromQuery] ClienteEntity cliente)
        {
            var clientes = _clienteServices.GetById(cliente.Id);

            if (clientes == null)
            {
                return NotFound("Nenhum cliente encontrado!");
            }
            return Ok(clientes);
        }

        /// <summary>
        /// Deleta Cliente por Id
        /// </summary>
        /// <param name="id">Id do cliente</param>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="200">Ok</response>
        [SwaggerOperation(Tags = new[] { _swaggerName })]
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

        /// <summary>
        /// Insere Cliente
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="200">Ok</response>
        [SwaggerOperation(Tags = new[] { _swaggerName })]
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

        /// <summary>
        /// Atualiza Cliente
        /// </summary>
        /// <response code="400">Bad Request</response>
        /// <response code="500">Internal Server Error</response>
        /// <response code="200">Ok</response>
        [SwaggerOperation(Tags = new[] { _swaggerName })]
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
