using MediatR;

namespace Application.Commands.Associados
{
    public class CreateAssociadoCommand : IRequest<CreateAssociadoCommandResult>
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

    }
}