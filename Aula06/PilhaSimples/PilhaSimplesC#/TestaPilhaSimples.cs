using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    public class TestaPilhaSimples
    {
		public static void Main(String[] args)
		{

			PilhaSimples p = new PilhaSimples(10);

			p.push(5);
			p.push(4);
			p.push(3);
			p.push(2);
			p.push(1);

			Console.WriteLine(p.pop());
			Console.WriteLine(p.pop());
			Console.WriteLine(p.pop());
			Console.WriteLine(p.pop());
			Console.WriteLine(p.pop());


		}
	}
}
