using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio2_v2.Modelagem
{
    public class Contato
    {
        public string Nome { get; }
        public int Idade { get; }
        public double Altura { get;  }

        public Contato(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }
}
