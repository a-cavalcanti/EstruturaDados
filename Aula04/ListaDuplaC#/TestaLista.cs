using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_ListaDupla
{
    public class TestaLista
    {
        public static void Main(string[] args)
        {
            ListaDupla lista = new ListaDupla();

            Pessoa p1 = new Pessoa("João", "M", 20);
            Pessoa p2 = new Pessoa("José", "M", 30);
            Pessoa p3 = new Pessoa("Maria", "F", 25);
            Pessoa p4 = new Pessoa("Carla", "F", 35);

            lista.inserirPrimeiro(p1);
            lista.inserirPrimeiro(p2);
            lista.imprimirLista();

            lista.inserirUltimo(p3);
            lista.imprimirLista();

            lista.inserirUltimo(p4);
            lista.imprimirLista();

            lista.removerUltimo();
            lista.imprimirLista();

            lista.removerPrimeiro();
            lista.imprimirLista();
        }
    }
}
