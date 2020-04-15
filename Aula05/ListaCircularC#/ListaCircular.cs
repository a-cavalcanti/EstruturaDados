using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    public class ListaCircular
    {
        private Nodo inicio;
        private int quantidadeNodos;
        
        public ListaCircular()
        {
            this.inicio = null;
            this.quantidadeNodos = 0;
        }

        public void inserirElemento(Pessoa p1)
        {
            Nodo novoNodo = new Nodo(p1);

            if (isEmpty())
            {
                inicio = novoNodo;
                inicio.setProximo(novoNodo);
                inicio.setAnterior(novoNodo);
            }
            else
            {
                Nodo aux = inicio;
                while(aux.getProximo() != inicio)
                {
                    aux = aux.getProximo();
                }
                aux.setProximo(novoNodo);
                novoNodo.setAnterior(aux);
                novoNodo.setProximo(inicio);
                inicio.setAnterior(novoNodo);
            }
            quantidadeNodos++;
        }

        

        public void exibirOrdem()
        {
            Nodo aux = inicio;
            String mensagem="";

            do
            {
                mensagem += aux.getPessoa().getNome() + " -> ";
                aux = aux.getProximo();
            } while (aux != inicio);
            
            Console.WriteLine(mensagem);
        }



        public bool isEmpty()
        {
            return (this.inicio == null);
        }


    }
}
