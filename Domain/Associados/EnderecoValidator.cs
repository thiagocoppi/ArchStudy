using FluentValidation;

namespace Domain.Associados
{
    public sealed class EnderecoValidator : AbstractValidator<Endereco>
    {
        public EnderecoValidator()
        {
            RuleFor(r => r.Logradouro)
                .NotEmpty();

            RuleFor(r => r.Numero)
                .GreaterThan(0);
        }
    }
}