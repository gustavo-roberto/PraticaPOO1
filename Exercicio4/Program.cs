using Exercicio4.Modelos;

namespace Exercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Televisao televisao = new Televisao(2, 1);

            Controle controle = new Controle(televisao);

        }
    }
}
