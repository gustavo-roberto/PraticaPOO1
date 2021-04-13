using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio2_v2.Contratos
{
    interface IAgenda
    {
        void AddContato(string nome, int idade, double altura);
        void RemoverContato(string nome);
        void ImprimirContatos();
        int BuscarContato(string nome);
        void ImprimirContato(int i);

    }
}
