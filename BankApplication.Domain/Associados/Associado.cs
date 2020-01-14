using BankApplication.Domain.Associados.ValueObjects;
using System;

namespace BankApplication.Domain.Associados
{
    public abstract class Associado
    {
        public Associado()
        {
        }

        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public Sexo Genero { get; protected set; }
        public DadosPessoais DadosPessoais { get; protected set; }
    }
}