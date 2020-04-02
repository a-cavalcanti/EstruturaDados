using System;

namespace Aula03_ListaPessoa
{    
    class Nodo {
        private Pessoa pessoa;
        private Nodo proximo;
        
        public Nodo(Pessoa pessoa1) {
            this.pessoa = pessoa1;
            this.proximo = null;
        }

        public Pessoa getPessoa() {
            return pessoa;
        }

        public void setPessoa(Pessoa pessoa) {
            this.pessoa = pessoa;
        }

        public Nodo getProximo() {
            return proximo;
        }

        public void setProximo(Nodo proximo) {
            this.proximo = proximo;
        }
    }
    
}