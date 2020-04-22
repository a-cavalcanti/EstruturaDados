
public class Pilha {

	private Nodo topo;
	private int tamanho;
	
	
	public Pilha() {
		this.topo = null;
		this.tamanho = 0;
	}
	
		
	public void exibePilha() {
		Nodo aux = topo;
		String elementos="";
		
		while(aux != null) {
			elementos += aux.getNome() + " -> ";
			aux = aux.getProximo();
		}
		System.out.println(elementos);
	}
	
	public String getNomeTopo() {
		return topo.getNome();
	}

	public boolean isEmpty() {
		if(topo == null)
			return true;
		else
			return false;
	}
	
	
}
