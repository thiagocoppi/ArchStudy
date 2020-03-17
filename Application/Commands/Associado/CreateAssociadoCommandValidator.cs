using FluentValidation;

namespace Application.Commands.Associado
{
    public class CreateAssociadoCommandValidator : AbstractValidator<CreateAssociadoCommand>
    {
        public CreateAssociadoCommandValidator()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty();
        }
    }
}