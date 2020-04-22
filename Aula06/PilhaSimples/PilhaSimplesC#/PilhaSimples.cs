using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    public class PilhaSimples
    {
		int[] elementos;
		int topo;
		int max;

		public PilhaSimples(int tam)
		{
			elementos = new int[tam];
			topo = -1; //pos invalida do vetor
			max = tam - 1;
		}

		public void push(int e)
		{
			if (isFull())
			{
				Console.WriteLine("Pilha cheia! ");
			}
			else
			{
				topo++;
				elementos[topo] = e;
			}
		}

		public int pop()
		{
			if (isEmpty())
			{
				Console.WriteLine("Pilha vazia! ");
				return 0;
			}
			else
			{
				int e;
				e = elementos[topo];
				topo--;
				return e;
			}
		}

		public int top()
		{
			if (isEmpty())
			{
				Console.WriteLine("Pilha vazia! ");
				return 0;
			}
			else
			{
				return elementos[topo];
			}
		}

		public bool isEmpty()
		{
			if (topo == -1)
				return true;
			else
				return false;
		}

		public bool isFull()
		{
			if (topo == max)
				return true;
			else
				return false;
		}
	}
}
