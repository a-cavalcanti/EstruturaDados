using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class TestaPilha
    {
		public static void Main(String[] args)
		{
			Pilha p = new Pilha();

			p.push("João");
			p.push("José");
			p.push("Paulo");

			p.exibePilha();

			//Console.WriteLine("Elemento removido " + p.pop());
			//Console.WriteLine("Elemento removido " + p.pop());

			//p.exibePilha();
		}
	}
}
