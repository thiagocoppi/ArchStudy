using Domain.Associados;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Associados
{
    public class CreateAssociadoCommandHandler : IRequestHandler<CreateAssociadoCommand, CreateAssociadoCommandResult>
    {
        private readonly IAssociadoService _associadoService;

        public CreateAssociadoCommandHandler(IAssociadoService associadoService)
        {
            _associadoService = associadoService;
        }

        public async Task<CreateAssociadoCommandResult> Handle(CreateAssociadoCommand request, CancellationToken cancellationToken)
        {
            var associadoCadastrado = await _associadoService.CadastrarAssociado(new Associado(request.Nome, request.Idade, "07052429942", new Endereco("Rua Ursa Maior", 454, "")));

            return new CreateAssociadoCommandResult() { Nome = request.Nome, Id = associadoCadastrado.Id };
        }
    }
}