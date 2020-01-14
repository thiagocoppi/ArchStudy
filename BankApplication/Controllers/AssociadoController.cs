using BankApplication.Application.Commands.Associado;
using BankApplication.Application.Commands.Transferencias;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociadoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AssociadoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CriarAssociadoInput associado)
        {
            var x = await _mediator.Send(associado);

            return Ok(x);
        }

        // POST api/values
        [Route("transferir")]
        [HttpPost]
        public async Task<IActionResult> Transferir([FromBody] TransferenciaCommand transferencia)
        {
            var x = await _mediator.Send(transferencia);

            return Ok("Foi");
        }
    }
}