using Domain.Associados;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Associado
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
            var associadoCadastrado = await _associadoService.CadastrarAssociado(new Domain.Associados.Associado(request.Nome,
                request.Idade, "07052429942", new Endereco("ABC", 0, string.Empty)));

            return new CreateAssociadoCommandResult() { Nome = request.Nome };
        }
    }
}