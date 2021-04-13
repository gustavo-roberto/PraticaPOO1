using System;
using System.Collections.Generic;

namespace Exercicio2.Modelos
{
    public class Contato
    {
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public Contato(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
    }
}
