namespace Domain.Associados
{
    public class Associado : BaseEntity
    {
        public Associado(string nome, int idade, string cPF, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            CPF = cPF;
            Endereco = endereco;

            Validate(this, new AssociadoValidator());
        }

        protected Associado()
        {
        }

        public string CPF { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public int Idade { get; protected set; }
        public string Nome { get; protected set; }
    }
}