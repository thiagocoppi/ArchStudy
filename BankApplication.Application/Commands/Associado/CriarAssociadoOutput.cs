namespace BankApplication.Application.Commands.Associado
{
    public sealed class CriarAssociadoOutput 
    {
        public CriarAssociadoOutput(string nome, string codigoConta)
        {
            Nome = nome;
            CodigoConta = codigoConta;
        }

        public string Nome { get; }
        public string CodigoConta { get; }
    }
}