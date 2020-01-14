using MediatR;

namespace BankApplication.Application.Commands.Transferencias
{
    public sealed class TransferenciaCommand : IRequest
    {
        public string ContaDestino { get; set; }

        public TransferenciaCommand(string contaDestino)
        {
            ContaDestino = contaDestino;
        }
    }
}