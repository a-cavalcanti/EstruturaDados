
public class TestaFila {

	public static void main(String[] args) {

		Fila p = new Fila();

		p.inserir("João");
		p.inserir("José");
		p.inserir("Paulo");
		p.inserir("Maria");

		p.frenteFila();

		p.exibeFila();
		p.remover();
		p.exibeFila();
		p.remover();
		p.exibeFila();
		p.remover();
		p.exibeFila();

	}

}
