using Application.Commands.Associado;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArchStudy.Controllers
{
    public class AssociadoController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAssociadoCommand command)
        {
            var createAssociadoResult = await Mediator.Send(command);

            return Ok(createAssociadoResult);
        }
    }
}