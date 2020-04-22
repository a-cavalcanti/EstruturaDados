using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Pilha
    {
		private Nodo topo;
		private int tamanho;


		public Pilha()
		{
			this.topo = null;
			this.tamanho = 0;
		}

		
		public void exibePilha()
		{
			Nodo aux = topo;
			String elementos = "";

			while (aux != null)
			{
				elementos += aux.getNome() + " -> ";
				aux = aux.getProximo();
			}
			Console.WriteLine(elementos);
		}

		public String getNomeTopo()
		{
			return topo.getNome();
		}

		public bool isEmpty()
		{
			if (topo == null)
				return true;
			else
				return false;
		}
	}
}
