using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_ListaDuplaCompleto
{
    
    public class Nodo
    {
        private Pessoa pessoa;
        private Nodo proximo;
        private Nodo anterior;


        public Nodo(Pessoa pessoa1)
        {
            this.pessoa = pessoa1;
            this.proximo = null;
            this.anterior = null;
        }

        public Nodo()
        {

        }

        public Pessoa getPessoa()
        {
            return pessoa;
        }

        public void setPessoa(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }

        public Nodo getProximo()
        {
            return proximo;
        }

        public void setProximo(Nodo proximo)
        {
            this.proximo = proximo;
        }

        public Nodo getAnterior()
        {
            return anterior;
        }

        public void setAnterior(Nodo anterior)
        {
            this.anterior = anterior;
        }
    }

    public class Pessoa
    {

        private String nome;
        private String sexo;
        private int idade;

        public Pessoa(String nome1, String sexo1, int idade1)
        {
            this.nome = nome1;
            this.sexo = sexo1;
            this.idade = idade1;
        }

        public Pessoa()
        {

        }


        public String getNome()
        {
            return nome;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getSexo()
        {
            return sexo;
        }
        public void setSexo(String sexo)
        {
            this.sexo = sexo;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }


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
            if (primeiro == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class TestaListaCompleto
    {
        public static void Main(string[] args)
        {
            ListaDupla lista = new ListaDupla();

            Pessoa p1 = new Pessoa("João", "M", 20);
            Pessoa p2 = new Pessoa("José", "M", 30);
            Pessoa p3 = new Pessoa("Maria", "F", 25);
            Pessoa p4 = new Pessoa("PAULO", "F", 35);

            lista.inserirPrimeiro(p1);
            lista.inserirPrimeiro(p2);
            lista.imprimirLista();

            lista.inserirUltimo(p3);
            lista.imprimirLista();

            lista.inserirUltimo(p4);
            lista.imprimirLista();           

            lista.removerUltimo();
            lista.imprimirLista();

            lista.removerPrimeiro();
            lista.imprimirLista();
        }

    }


}
