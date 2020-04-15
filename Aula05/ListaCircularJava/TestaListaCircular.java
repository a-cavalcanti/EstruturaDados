
public class TestaListaCircular {

	public static void main(String[] args) {
		
		ListaCircular lista = new ListaCircular();
        Pessoa p1 = new Pessoa("Anderson", "M", 29);
        Pessoa p2 = new Pessoa("João", "M", 29);
        Pessoa p3 = new Pessoa("José", "M", 29);
        Pessoa p4 = new Pessoa("Maria", "F", 29);

        lista.inserirElemento(p1);
        lista.inserirElemento(p2);
        lista.inserirElemento(p3);
        lista.inserirElemento(p4);

        lista.exibirOrdem();


	}

}
