using MediatR;

namespace BankApplication.Application.Commands.Associado
{
    /// <summary>
    /// Input para criação de um novo associado
    /// </summary>
    public sealed class CriarAssociadoInput : IRequest<CriarAssociadoOutput>
    {
        /// <summary>
        /// Nome do associado que será cadastrado
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Endereço do associado que será cadastrado
        /// </summary>
        public EnderecoInput Endereco { get; set; }

        public CriarAssociadoInput(string nome, EnderecoInput endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }
    }
}