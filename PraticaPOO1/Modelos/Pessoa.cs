
using System;

namespace PraticaPOO1.Modelos
{
    public class Pessoa
    {
        public string Nome { get; set; }

        private DateTime _dataNascimento;
        public DateTime Nascimento
        {
            get => _dataNascimento;

            set 
            {
                if(value > DateTime.Parse("01/01/1900") && value < DateTime.Now)
                {
                    _dataNascimento = value;
                }
                else
                {
                    Console.WriteLine("A data deve ser superior ao ano 1900 e menor do que o instante atual");
                }
            }
        }
        public double Altura { get; set; }

        public void MostrarDados()
        {
            Console.WriteLine("Nome: " + Nome + "\n" +
                              "Data de Nascimento: " + Nascimento + "\n" +
                              "Altura: " + Altura);
        }

        public void ObterIdade()
        {
            int intervaloAnos = (DateTime.Now.Year - Nascimento.Year);
            int intervaloMeses = DateTime.Now.Month - Nascimento.Month;

            if(DateTime.Now.DayOfYear >  Nascimento.DayOfYear)
            {
                MostrarIdade(intervaloAnos, intervaloMeses);
            }
            else
            {
                MostrarIdade(intervaloAnos - 1, intervaloMeses + 12);
            }
        }

        private void MostrarIdade(int anos, int meses)
        {
            Console.WriteLine("Idade: " + anos + " anos e " + meses + " meses!");
        }

    }
}
