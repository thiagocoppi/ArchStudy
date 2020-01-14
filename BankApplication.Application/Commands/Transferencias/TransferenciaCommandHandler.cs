using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BankApplication.Application.Commands.Transferencias
{
    public sealed class TransferenciaCommandHandler : IRequestHandler<TransferenciaCommand>
    {
        public Task<Unit> Handle(TransferenciaCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Ok");

            return Task.FromResult(new Unit());
        }
    }
}