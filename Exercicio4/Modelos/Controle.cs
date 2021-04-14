using Exercicio4.Contratos;
using System;

namespace Exercicio4.Modelos
{
    public class Controle : IControle
    {
        private Televisao _tv;
        public Controle(Televisao televisao)
        {
            _tv = televisao;
        }
        public void AumentarCanal()
        {
            _tv.Canal++;
        }

        public void AumentarVolume()
        {
            if(_tv.Volume == 3)
            {
                return;
            }
            _tv.Volume++;
        }

        public void ConsultarCanal()
        {
            Console.WriteLine(_tv.Canal);
        }

        public void ConsultarVolume()
        {
            Console.WriteLine(_tv.Volume);
        }

        public void DiminuirCanal()
        {
            if(_tv.Canal == 0)
            {
                return;
            }

            _tv.Canal--;
        }

        public void DiminuirVolume()
        {
            if(_tv.Volume == 0)
            {
                return;
            }

            _tv.Volume--;
        }

        public void PularParaCanal(int canal)
        {
            if(canal < 0)
            {
                return;
            }

            _tv.Canal = canal;
        }
    }
}
