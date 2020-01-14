using BankApplication.Domain.Associados.ValueObjects;
using System;

namespace BankApplication.Infraestrutura.Entities
{
    public sealed class Associado : Domain.Associados.Associado
    {
        public Associado()
        {
        }

        public Associado(string nome, Endereco endereco, Sexo genero, DadosPessoais dadosPessoais)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Genero = genero;
            DadosPessoais = dadosPessoais;
        }
    }
}