using Application.Commands.Associado;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ArchStudy.Controllers
{
    public class AssociadoController : ApiController
    {
        private readonly ILogger<AssociadoController> _logger;
        
        public AssociadoController(ILogger<AssociadoController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAssociadoCommand command)
        {
            _logger.LogInformation("Request receive from {name}, with JSON {json}, data execução {data}", nameof(AssociadoController), JsonConvert.SerializeObject(command), DateTime.UtcNow);
            var createAssociadoResult = await Mediator.Send(command);

            return Ok(createAssociadoResult);
        }
    }
}