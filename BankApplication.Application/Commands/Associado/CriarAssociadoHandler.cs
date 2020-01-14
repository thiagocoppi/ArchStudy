using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BankApplication.Application.Commands.Associado
{
    public sealed class CriarAssociadoHandler : IRequestHandler<CriarAssociadoInput, CriarAssociadoOutput>
    {
        public Task<CriarAssociadoOutput> Handle(CriarAssociadoInput request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CriarAssociadoOutput("Primeiro associado", "1234"));
        }
    }
}