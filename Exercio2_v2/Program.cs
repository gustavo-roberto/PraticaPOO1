using Exercio2_v2.Modelagem;
using System;

namespace Exercio2_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();

            agenda.AddContato("João", 32, 1.6);
            agenda.AddContato("Amanda", 18, 1.7);
            agenda.AddContato("Gustavo", 25, 1.9);
            agenda.AddContato("Gerson", 1, 0.5);
            agenda.AddContato("Margarete", 48, 1.8);
            agenda.AddContato("Roberto", 56, 1.85);

            Console.WriteLine("Indice do contato roberto é: " + agenda.BuscarContato("Roberto"));

            agenda.RemoverContato("Amanda");

            agenda.ImprimirContatos();

            Console.WriteLine("O índice do contato Roberto é: " + agenda.BuscarContato("Roberto"));

            agenda.ImprimirContato(0);

            agenda.RemoverContato("Banze");
        }
    }
}
