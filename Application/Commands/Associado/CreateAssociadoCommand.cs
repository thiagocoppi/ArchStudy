using MediatR;

namespace Application.Commands.Associado
{
    public class CreateAssociadoCommand : IRequest<CreateAssociadoCommandResult>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

    }
}