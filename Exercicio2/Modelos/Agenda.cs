using Exercicio2.Interfaces;
using System;

namespace Exercicio2.Modelos
{
    public class Agenda : IAgenda
    {
        private Contato[] contatos = new Contato[10];
        static int indiceContatos = 0;

        public void AddContato(string nome, int idade, double altura)
        {
            if(indiceContatos < 10)
            {
                contatos[indiceContatos++] = new Contato(nome, idade, altura);
            }
            else
            {
                Console.WriteLine("A agenda está cheia! Remova algum contato para adicionar um novo.");
            }
        }

        public int EncontrarIndice(string nome)
        {
            for(int i = 0; i < indiceContatos; i++)
            {
                if(contatos[i].Nome == nome)
                {
                    return i;
                }                
            }

            return -99;
        }

        public void RemoverContato(string nome)
        {
            int indice = EncontrarIndice(nome);

            if(indice  == -99)
            {
                Console.WriteLine("Contato não encontrato");
                return;
            }

            indiceContatos--;

            for (int i = indice; i < indiceContatos; i++)
            {
                contatos[i] = contatos[i + 1];
            }                       

            Console.WriteLine("Contato removido");
        }

        public int BuscarContato(string nome)
        {
            return EncontrarIndice(nome);            
        }

        public void ImprimirContatos()
        {
            for(int i = 0; i < indiceContatos; i++)
            {
                ImprimirContatoEspecifico(i);
            }
        }

        public void ImprimirContato(int indice)
        {
            if(indice >= 0 && indice <= indiceContatos)
            {
                ImprimirContatoEspecifico(indice);
            }
            else
            {
                Console.WriteLine("O indice não não conrresponde a um contato da agenda");
            }
        }

        public void ImprimirContatoEspecifico(int i)
        {
            Console.WriteLine("Nome: " + contatos[i].Nome + "\n" +
                                "Idade: " + contatos[i].Idade + "\n" + 
                                "Altura: " + contatos[i].Altura + "\n");
        }
    }
}
