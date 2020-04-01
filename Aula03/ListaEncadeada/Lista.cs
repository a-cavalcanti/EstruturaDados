using System;

namespace ListaEncadeada
{    
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

}