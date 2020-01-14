using FluentValidation;

namespace BankApplication.Application.Commands.Associado.Validator
{
    public sealed class CriarAssociadoValidator : AbstractValidator<CriarAssociadoInput>
    {
        public CriarAssociadoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Nome).NotNull();
            RuleFor(x => x.Endereco).NotNull();
        }
    }
}