using Exercicio2.Modelos;
using System;
using System.CodeDom.Compiler;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            Agenda agenda = new Agenda();

            agenda.AddContato("João", 32, 1.6);
            agenda.AddContato("Amanda", 18, 1.7);
            agenda.AddContato("Gustavo", 25, 1.9);
            agenda.AddContato("Gerson", 1, 0.5);
            agenda.AddContato("Margarete", 48, 1.8);
            agenda.AddContato("Roberto", 56, 1.85);

            agenda.ImprimirContatos();

            Console.WriteLine("-------------------------------------------------");

            agenda.RemoverContato("Gustavo");
            agenda.ImprimirContatos();
            agenda.ImprimirContato(3);

            while(continuar == true)
            {

                Console.WriteLine("Digite algum nome ou 'Encerrar' para finalizar o processamento");

                string nome = Console.ReadLine();

                if(nome == "Encerrar")
                {
                    continuar = false;
                }
                else
                {
                    int indice = agenda.BuscarContato(nome);

                    if (indice == -99)
                    {
                        Console.WriteLine("Não foi encontrado um índice equivalente ao nome fornceido.");
                    }
                    else
                    {
                        Console.WriteLine("O índice na agenda para o nome fornecido é " + indice);
                    }
                }
            }
        }

    }
}
