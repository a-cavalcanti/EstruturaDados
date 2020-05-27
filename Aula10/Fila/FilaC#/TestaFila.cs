using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    public class TestaFila
    {
		public static void Main(String[] args)
		{
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
}
