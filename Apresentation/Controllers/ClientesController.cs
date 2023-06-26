using Application.DTO.DTOS;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {

        private readonly IApplicationServiceCliente _applicationServiceCliente;


        public ClientesController(IApplicationServiceCliente ApplicationServiceCliente)
        {
            _applicationServiceCliente = ApplicationServiceCliente;

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServiceCliente.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationServiceCliente.GetById(id));
        }

        // POST api/values12
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO clienteDTO)
        {
            if (clienteDTO == null)
                return NotFound();

            _applicationServiceCliente.Add(clienteDTO);
            return Ok("Cliente Cadastrado com sucesso!");
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClienteDTO clienteDTO)
        {
            if (clienteDTO == null)
                return NotFound();

            _applicationServiceCliente.Update(clienteDTO);
            return Ok("Cliente Atualizado com sucesso!");

        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClienteDTO clienteDTO)
        {
            if (clienteDTO == null)
                return NotFound();

            _applicationServiceCliente.Remove(clienteDTO);
            return Ok("Cliente Removido com sucesso!");
        }
    }
}