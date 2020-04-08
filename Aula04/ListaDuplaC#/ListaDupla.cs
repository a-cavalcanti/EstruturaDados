using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_ListaDupla
{
    public class ListaDupla
    {
        private Nodo primeiro;
        private Nodo ultimo;
        private int quantidadeNodos;

        public ListaDupla()
        {
            this.primeiro = null;
            this.ultimo = null;
            this.quantidadeNodos = 0;
        }

        public Nodo getPrimeiro()
        {
            return primeiro;
        }

        public void setPrimeiro(Nodo primeiro)
        {
            this.primeiro = primeiro;
        }

        public Nodo getUltimo()
        {
            return ultimo;
        }

        public void setUltimo(Nodo ultimo)
        {
            this.ultimo = ultimo;
        }

        public int getQuantidadeNodos()
        {
            return quantidadeNodos;
        }

        public void setQuantidadeNodos(int quantidadeNodos)
        {
            this.quantidadeNodos = quantidadeNodos;
        }

        public void inserirPrimeiro(Pessoa p1)
        {
            Nodo novoNodo = new Nodo(p1);
            if (isEmpty())
            {
                primeiro = novoNodo;
                ultimo = novoNodo;
            }
            else
            {
                novoNodo.setProximo(primeiro);
                primeiro.setAnterior(novoNodo);
                primeiro = novoNodo;
            }
            quantidadeNodos++;
        }

        public void inserirUltimo(Pessoa p1)
        {
            
        }

        public void removerPrimeiro()
        {
            if (isEmpty())
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                primeiro = primeiro.getProximo();
                primeiro.setAnterior(null);
                quantidadeNodos--;
            }
        }

        public void removerUltimo()
        {
            
        }

        

        public String pesquisarNodo(String nome)
        {
            String mensagem = "";
            Nodo atual = primeiro;
            while ((atual != null) && (!Equals(atual.getPessoa().getNome(), nome)))
            {
                atual = atual.getProximo();
            }
            return mensagem = "Nome: " + atual.getPessoa().getNome() + "\n" +
                    "Sexo: " + atual.getPessoa().getSexo() + "\n" +
                    "Idade: " + atual.getPessoa().getIdade();
        }

        public void imprimirLista()
        {

            String mensagem = "";

            if (isEmpty())
            {
                mensagem = "A lista esta vazia!";
            }
            else
            {
                Nodo atual = primeiro;
                while (atual != null)
                {
                    mensagem += atual.getPessoa().getNome() + " -> ";
                    atual = atual.getProximo();
                }
            }
            Console.WriteLine(mensagem);
        }

        public bool isEmpty()
        {
            if(primeiro == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
