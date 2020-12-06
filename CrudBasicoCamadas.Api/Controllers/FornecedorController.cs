using CrudBasicoCamadas.Domain.Entities;
using CrudBasicoCamadas.Domain.Interfaces.IService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrudBasicoCamadas.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("Fornecedor")]
    public class FornecedorController : Controller
    {
        private readonly IFornecedorService _fornecedorService;
        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpGet]
        public ActionResult<List<FornecedorEntity>> GetAll()
        {
            var fonecedores = _fornecedorService.GetAll();
            if (fonecedores == null)
            {
                return NotFound("Nenhum fornecedor encontrado!");
            }
            return Ok(fonecedores);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<List<FornecedorEntity>> GetById([FromHeader] FornecedorEntity fornecedor)
        {
            var fonecedores = _fornecedorService.GetById(fornecedor.Id);
            if (fonecedores == null)
            {
                return NotFound("Nenhum fornecedor encontrado!");
            }
            return Ok(fonecedores);
        }
        [HttpDelete]
        public ActionResult<FornecedorEntity> DeleteById([FromHeader] FornecedorEntity fornecedor)
        {
            var fornecedorDelete = _fornecedorService.DeleteById(fornecedor);

            if (!fornecedorDelete)
            {
                return BadRequest("Erro ao deletar Fornecedor!");
            }
            return Ok(fornecedorDelete);
        }

        [HttpPost]
        public ActionResult<FornecedorEntity> Insert([FromBody] FornecedorEntity fornecedor)
        {
            var fornecedorInsert = _fornecedorService.Insert(fornecedor);

            if (!fornecedorInsert)
            {
                return BadRequest("Erro ao salvar Fornecedor!");
            }
            return Ok(fornecedorInsert);
        }

        [HttpPut]
        public ActionResult<FornecedorEntity> Update([FromBody] FornecedorEntity fornecedor)
        {
            var fornecedorInsert = _fornecedorService.Update(fornecedor);

            if (!fornecedorInsert)
            {
                return BadRequest("Erro ao autualizar Fornecedor!");
            }
            return Ok(fornecedorInsert);
        }
    }
}
