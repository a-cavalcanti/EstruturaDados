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
    
}