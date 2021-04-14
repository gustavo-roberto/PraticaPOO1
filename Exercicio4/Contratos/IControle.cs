using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.Contratos
{
    public interface IControle
    {
        void AumentarVolume();
        void DiminuirVolume();
        void AumentarCanal();
        void DiminuirCanal();
        void PularParaCanal(int canal);
        void ConsultarVolume();
        void ConsultarCanal();
    }
}
