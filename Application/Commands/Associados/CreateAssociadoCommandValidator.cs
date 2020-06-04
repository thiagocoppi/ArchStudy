using FluentValidation;

namespace Application.Commands.Associados
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