using Exercicio3.Modelos;

namespace Exercicio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Elevador elevador = new Elevador(4, 4);

            elevador.Descer();
            elevador.Subir();
            elevador.Subir();
            elevador.Subir();
            elevador.Subir();
            elevador.Subir();

            elevador.Descer();
            elevador.MostrarAndarAtual();

            elevador.Sair();

            elevador.Entrar();
            elevador.Entrar();
            elevador.Entrar();
            elevador.Entrar();
            elevador.Entrar();

            elevador.Sair();
            elevador.MostrarNumAtualOcupantes();
        }
    }
}
