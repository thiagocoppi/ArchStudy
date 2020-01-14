using System;
using System.Collections.Generic;
using System.Text;

namespace BankApplication.Domain.Associados.ValueObjects
{
    public class DadosPessoais
    {
        public string CPF { get; set; }
        public string Profissao { get; set; }
        public decimal Salario { get; set; }
        public int Idade { get; set; }
    }
}
