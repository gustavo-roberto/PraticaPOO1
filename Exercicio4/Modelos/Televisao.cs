
namespace Exercicio4.Modelos
{
    public class Televisao
    {
        public int Canal { get; set; }
        public int Volume { get; set; }

        public Televisao(int canal, int volume)
        {
            Canal = canal;
            Volume = volume;
        }
    }
}
