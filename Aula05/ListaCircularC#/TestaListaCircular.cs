using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    public class TestaListaCircular
    {
        public static void Main(String[] args)
        {
            ListaCircular lista = new ListaCircular();
            Pessoa p1 = new Pessoa("Anderson", "M", 25);
            Pessoa p2 = new Pessoa("João", "M", 32);
            Pessoa p3 = new Pessoa("José", "M", 40);
            Pessoa p4 = new Pessoa("Maria", "F", 39);

            lista.inserirElemento(p1);
            lista.inserirElemento(p2);
            lista.inserirElemento(p3);
            lista.inserirElemento(p4);

            lista.exibirOrdem();

        }
    }
}
