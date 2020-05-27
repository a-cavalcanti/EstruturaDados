
public class Fila
	{
		private Nodo primeiro;
		private Nodo ultimo;
		private int tamanho;


		public Fila()
		{
			this.primeiro = null;
			this.ultimo = null;
			this.tamanho = 0;
		}

		public void inserir(String s)
		{
			Nodo novoNodo = new Nodo(s);

			if (isEmpty())
			{
				primeiro = novoNodo;
				ultimo = novoNodo;
				tamanho++;
			}
			else
			{
				ultimo.setProximo(novoNodo);
				ultimo = novoNodo;
				tamanho++;
			}
		}

		public void remover()
		{
			if (isEmpty())
			{
				System.out.println("Lista Vazia! ");
			}
			else
			{				
				Nodo aux = primeiro.getProximo();
				primeiro = aux;
				tamanho--;
			}
		}

		public void frenteFila()
		{
			System.out.println("Frente da fila " + primeiro.getNome());
		}

		public void exibeFila()
		{
			Nodo aux = primeiro;
			String elementos = "";

			while (aux != null)
			{
				elementos += aux.getNome() + " <- ";
				aux = aux.getProximo();
			}
			System.out.println(elementos);
		}


		public boolean isEmpty()
		{
			if (primeiro == null)
				return true;
			else
				return false;
		}
	}
