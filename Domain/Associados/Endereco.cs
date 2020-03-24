using Domain.Base;

namespace Domain.Associados
{
    public class Endereco : ValidatorDomain
    {
        public Endereco(string logradouro, int numero, string complemento)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;

            Validate(this, new EnderecoValidator());
        }

        protected Endereco()
        {
        }

        public string Complemento { get; protected set; }
        public string Logradouro { get; protected set; }
        public int Numero { get; protected set; }
    }
}