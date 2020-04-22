
public class Pilha {
	
	int elementos[];
	int topo;
	int max;
	
	public Pilha(int tam) {
		elementos = new int[tam];
		topo = -1; //pos invalidad do vetor
		max = tam-1;
	}
	
	public void push(int e) {
		if (isFull()) {
			System.out.println("Pilha cheia! ");
		}else {
			topo++;
			elementos[topo] = e;
		}
	}
	
	public int pop() {
		if (isEmpty()) {
			System.out.println("Pilha vazia! ");
			return 0;
		}else {
			int e;
			e = elementos[topo];
			topo--;
			return e;
		}
	}
	
	public int top() {
		if (isEmpty()) {
			System.out.println("Pilha vazia! ");
			return 0;
		}else {
			return elementos[topo];
		}
	}
	
	public boolean isEmpty() {
		if(topo == -1) 
			return true;
		else
			return false;
	}
	
	public boolean isFull() {
		if(topo == max)
			return true;
		else
			return false;
	}
}
