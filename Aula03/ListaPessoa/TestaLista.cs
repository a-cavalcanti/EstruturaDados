using System;

namespace testalista
{
    class Pessoa {

        private String nome;
        private String sexo;
        private int idade;	        
        
        public String getNome() {
            return nome;
        }
        public void setNome(String nome) {
            this.nome = nome;
        }
        public String getSexo() {
            return sexo;
        }
        public void setSexo(String sexo) {
            this.sexo = sexo;
        }
        public int getIdade() {
            return idade;
        }
        public void setIdade(int idade) {
            this.idade = idade;
        }
    }

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

    class ListaSimples {
        
        private Nodo primeiro;
        private Nodo ultimo;
        private int quantidadeNodos;
        
        public ListaSimples() {
            this.primeiro = null;
            this.ultimo = null;
            this.quantidadeNodos = 0;
        }

        public Nodo getPrimeiro() {
            return primeiro;
        }

        public void setPrimeiro(Nodo primeiro) {
            this.primeiro = primeiro;
        }

        public Nodo getUltimo() {
            return ultimo;
        }

        public void setUltimo(Nodo ultimo) {
            this.ultimo = ultimo;
        }

        public int getQuantidadeNodos() {
            return quantidadeNodos;
        }

        public void setQuantidadeNodos(int quantidadeNodos) {
            this.quantidadeNodos = quantidadeNodos;
        }
        
        public void inserirPrimeiro(Pessoa p1) {
            Nodo novoNodo = new Nodo(p1);
            if (isEmpty()) {
                ultimo = novoNodo;
                novoNodo.setProximo(null);
            }else{
                novoNodo.setProximo(primeiro);
            }
            
            primeiro = novoNodo;
            quantidadeNodos++;		
        }
       
        
        public bool removerNodo(String nome) {
            
            Nodo atual = primeiro;
            Nodo anterior = null;
            
            if (isEmpty()) {
                return false;
            }else {
                while ( (atual != null) && (! Equals(atual.getPessoa().getNome(), nome) )) {
                    anterior = atual;
                    atual = atual.getProximo();				
                }
                if (atual == primeiro) { //se a pessoa que quero excluir estiver no primeiro nodo
                    if (primeiro == ultimo) {// se a lista só tiver 1 elemento
                        ultimo =null;
                    }
                    primeiro = primeiro.getProximo();
                }else {//se a pessoa que quero excluir não estiver no primeiro nodo
                    if (atual == ultimo) {//se a pessoa que quero excluir estiver no último nodo
                        ultimo = anterior;
                    }
                    anterior.setProximo(atual.getProximo());
                }
                quantidadeNodos--;
                return true;
            }
        }
        
        public bool isEmpty() {
            if (this.primeiro == null) {
                return true;
            }else {
                return false;
            }
        }
        
        public String pesquisarNodo(String nome) {
            String mensagem = "";
            Nodo atual = primeiro;
            while((atual != null) && (!Equals(atual.getPessoa().getNome(), nome)) ) {
                atual = atual.getProximo();
            }
            return mensagem = "Nome: " + atual.getPessoa().getNome()+"\n"+
                    "Sexo: " + atual.getPessoa().getSexo()+"\n"+
                    "Idade: " + atual.getPessoa().getIdade();
        }
        
        public void imprimirLista() {
            
            String mensagem = "";
            
            if (isEmpty()) {
                mensagem = "A lista esta vazia!";
            }else {
                Nodo atual = primeiro;
                while(atual != null ) {
                    mensagem += atual.getPessoa().getNome() + " -> ";
                    atual = atual.getProximo();
                }
            }
            Console.WriteLine(mensagem);
        }        
    }

    class MainClass {

        public static void Main(string[] args) {
            ListaSimples lista = new ListaSimples();
            
            Pessoa p = new Pessoa();
            p.setNome("João");
            p.setIdade(20);
            p.setSexo("M");
            
            Pessoa p2 = new Pessoa();
            p2.setNome("José");
            p2.setIdade(30);
            p2.setSexo("M");
            lista.inserirPrimeiro(p);
            lista.inserirPrimeiro(p2);
            
            lista.imprimirLista();
            
            lista.removerNodo("João");
            
            lista.imprimirLista();

        }

    }
    
}