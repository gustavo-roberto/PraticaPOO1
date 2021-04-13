using Exercicio3.Contratos;
using System;

namespace Exercicio3.Modelos
{
    public class Elevador : IElevador
    {
        private int AndarAtual;
        private int TotalAndares;
        private int CapacidadeElevador;
        private int NumPessoasPresentes;

        public Elevador(int totalAndares, int capacidadeElvador)
        {
            TotalAndares = totalAndares;
            CapacidadeElevador = capacidadeElvador;
            AndarAtual = 0;
            NumPessoasPresentes = 0;
        }

        public void Descer()
        {
            if(AndarAtual < 0)
            {
                Console.WriteLine("Não é possível descer mais pois já é o térreo");
            }
            else
            {
                AndarAtual--;
            }
        }

        public void Entrar()
        {
            if(NumPessoasPresentes > CapacidadeElevador)
            {
                Console.WriteLine("Elevador cheio demais");
            }
            else
            {
                NumPessoasPresentes++;
            }

        }

        public void Sair()
        {
            if(NumPessoasPresentes < 0)
            {
                Console.WriteLine("Não há nenhuma pessoa para sair");
            }
            else
            {
                NumPessoasPresentes--;
            }

        }

        public void Subir()
        {
            if(AndarAtual > TotalAndares)
            {
                Console.WriteLine("Não é possível subir mais");
            }
            else
            {
                AndarAtual++;
            }
        }

        public void MostrarNumAtualOcupantes()
        {
            Console.WriteLine("O número de ocupantes atual do elevador é: " + NumPessoasPresentes);
        }
    }
}
