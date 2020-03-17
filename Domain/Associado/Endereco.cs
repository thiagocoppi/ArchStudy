namespace Domain.Associado
{
    public class Endereco
    {
        public Endereco(string logradouro, int numero, string complemento)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
        }

        protected Endereco()
        {
        }

        public string Complemento { get; protected set; }
        public string Logradouro { get; protected set; }
        public int Numero { get; protected set; }
    }
}