using System;

namespace ListaEncadeada
{
    public class Nodo {
	
        private int elemento;
        private Nodo next;
        
        public Nodo(int s){
            elemento=s;
        }
        
        public Nodo() {            
        }
        
        public int getElemento(){
            return elemento;
        }
        
        public void setElemento(int elemento){
            this.elemento=elemento;
        }
        
        public Nodo getProximo(){
            return next;
        }
        
        public void setProximo(Nodo next){
            this.next=next;
        }	
    }



    public class Lista {

        private Nodo inicio;
        
        //criando a lista vazia
        public Lista() {
            this.inicio = null;
        }
        
        public void inserir(int elemento) {
            
            Nodo novoNodo = new Nodo();	//cria novo elemento	
            novoNodo.setElemento(elemento); //insere o elemento no Nodo
            novoNodo.setProximo(null); //Depois desse Nodo nao tem ninguem

            if(inicio == null) // lista vazia
            { 
                inicio = novoNodo;
            }
            else //a lista nao esta vazia
            {			
                Nodo aux = inicio;
                // chegar no ultimo Nodo que aponte para null
                while(aux.getProximo() != null){ 
                    aux = aux.getProximo();
                }
                aux.setProximo(novoNodo);
            }
        }
        
        public int retirar() {

            if(inicio != null) {
                Nodo aux = inicio;
                int elemento = aux.getElemento();
                inicio = aux.getProximo();
                return elemento;
            }else {
                Console.WriteLine("Lista vazia!");
                return -1;
            }
        }
        
        public void listar() {

            if(inicio == null){
                Console.WriteLine("A lista ta vazia!");
            }else{
                Nodo aux = inicio;
                while(aux != null){
                    Console.WriteLine("Elemento visto " + aux.getElemento());
                    aux = aux.getProximo();
                }
            }            
        }

        public bool isEmpty() {
            if( this.inicio == null) {
                return true;
            }else {
                return false;
            }
        }
    }



    public class ListaDeEspera{
        public static void Main(string[] args){
            Lista lista = new Lista();

            lista.inserir(100);
            lista.inserir(102);
            lista.inserir(202);
            lista.inserir(402);

            lista.listar();

            while(!lista.isEmpty()) {
                int e = lista.retirar();
                Console.WriteLine("Retirei o elemento " + e);
            }
        }
}
}