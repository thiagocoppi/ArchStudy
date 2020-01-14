using FluentValidation;

namespace BankApplication.Application.Commands.Associado.Validator
{
    public class EnderecoInputValidator : AbstractValidator<EnderecoInput>
    {
        public EnderecoInputValidator()
        {
            RuleFor(x => x.Logradouro).NotEmpty();
            RuleFor(x => x.Numero).NotEqual(0);
        }
    }
}