using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
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
}
