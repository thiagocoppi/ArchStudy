namespace BankApplication.Application.Commands.Associado
{
    /// <summary>
    /// Input referente ao endereço
    /// </summary>
    public sealed class EnderecoInput
    {
        /// <summary>
        /// Logradouro (Rua) que refere-se
        /// </summary>
        public string Logradouro { get; set; }
        /// <summary>
        /// Número do endereço (Casa)
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        public string Complemento { get; set; }

        public EnderecoInput(string logradouro, int numero, string complemento)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
        }
    }
}