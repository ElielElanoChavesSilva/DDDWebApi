using Application.DTO.DTOS;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutosController(IApplicationServiceProduto ApplicationServiceProduto)
        {
            _applicationServiceProduto = ApplicationServiceProduto;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO produtoDTO)
        {
                if (produtoDTO == null)
                    return NotFound();


                _applicationServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO produtoDTO)
        {
                if (produtoDTO == null)
                    return NotFound();

                _applicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDTO produtoDTO)
        {
                if (produtoDTO == null)
                    return NotFound();

                _applicationServiceProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");
        }
    }
}