using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
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
				Console.WriteLine("Lista Vazia! ");
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
			Console.WriteLine(primeiro.getNome());
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
			Console.WriteLine(elementos);
		}


		public bool isEmpty()
		{
			if (primeiro == null)
				return true;
			else
				return false;
		}
	}
}
