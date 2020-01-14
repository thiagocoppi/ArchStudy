namespace BankApplication.Domain.Associados.ValueObjects
{
    public class Endereco
    {
        public string Logradouro { get; protected set; }
        public int Numero { get; protected set; }
        public string Complemento { get; protected set; }

        protected Endereco()
        {

        }

        public Endereco(string logradouro, int numero, string complemento)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
        }
    }
}