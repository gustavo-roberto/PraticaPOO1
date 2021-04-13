using Exercio2_v2.Contratos;
using System;
using System.Collections.Generic;

namespace Exercio2_v2.Modelagem
{
    public class Agenda : IAgenda
    {
        private List<Contato> _contatos = new List<Contato>();
        
        public void AddContato(string nome, int idade, double altura)
        {
            if(_contatos != null && _contatos.Count > 10)
            {
                Console.WriteLine("A agenda tem 10 contatos. Remova um contato para adicionar um novo.");
            }
            else
            {
                _contatos.Add(new Contato(nome, idade, altura));
            }

        }

        public int BuscarContato(string nome)
        {
            return _contatos.IndexOf(_contatos.Find(x => x.Nome == nome));
        }

        public void ImprimirContatos()
        {
            for(int i = 0; i < _contatos.Count; i++)
            {
                ImprimirItem(i);
            }
        }

        public void ImprimirContato(int i)
        {
            if(i < 0 && i > _contatos.Count)
            {
                Console.WriteLine("O índice fornecido não corresponde a um contato");
            }

            ImprimirItem(i);
        }

        public void RemoverContato(string nome)
        {
            try
            {
                Contato x = _contatos.Find(m => m.Nome == nome);
                _contatos.Remove(x);
            }
            catch
            {
                Console.WriteLine("O nome não corresopnde a um contato da agenda");
            }
        }

        private void ImprimirItem(int indice)
        {
            var x = _contatos[indice];

            Console.WriteLine("Nome: " + x.Nome + "\n" +
                              "Idade: " + x.Idade + "\n" + 
                              "Altura: " + x.Altura + "\n");
        }
    }
}
