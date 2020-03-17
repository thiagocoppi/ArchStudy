using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Associado
{
    public class CreateAssociadoCommandHandler : IRequestHandler<CreateAssociadoCommand, CreateAssociadoCommandResult>
    {
        public Task<CreateAssociadoCommandResult> Handle(CreateAssociadoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new CreateAssociadoCommandResult()
            {
                Id = Guid.NewGuid(),
                Nome = "Associado"
            });
        }
    }
}
