using FluentValidation;

namespace Domain.Associados
{
    public sealed class AssociadoValidator : AbstractValidator<Associado>
    {
        public AssociadoValidator()
        {
            RuleFor(r => r.Nome)
                .NotNull()
                .NotEmpty();

            RuleFor(r => r.Endereco)
                .NotNull();

            RuleFor(r => r.CPF)
                .NotNull()
                .NotEmpty();
        }
    }
}