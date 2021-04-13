using PraticaPOO1.Modelos;
using System;

namespace PraticaPOO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime data = DateTime.Parse("01/07/1988 15:12:03");

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Vanessa";
            pessoa.Nascimento = data;
            pessoa.Altura = 1.90;

            pessoa.MostrarDados();
            pessoa.ObterIdade();

            pessoa.Nascimento = new DateTime(1988, 02, 01, 04, 32, 09);
            Console.WriteLine("\n\nNova idade : " + pessoa.Nascimento);
            pessoa.ObterIdade();
      
        }
    }
}
