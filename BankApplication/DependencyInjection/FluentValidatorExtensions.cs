using BankApplication.Application.Commands.Associado.Validator;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BankApplication.DependencyInjection
{
    public static class FluentValidatorExtensions
    {
        public static IServiceCollection AddFluentValidator(this IServiceCollection services)
        {
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(f =>
                f
                 .RegisterValidatorsFromAssemblyContaining<CriarAssociadoValidator>()
                 .RegisterValidatorsFromAssemblyContaining<EnderecoInputValidator>()
                 .ImplicitlyValidateChildProperties = true
                );

            return services;
        }
    }
}