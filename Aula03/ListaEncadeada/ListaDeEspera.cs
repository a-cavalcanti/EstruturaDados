using System;

namespace ListaEncadeada
{
    public class ListaDeEspera{
        public static void Main(string[] args){
            Lista lista = new Lista();

            lista.inserir(100);
            lista.inserir(102);
            lista.inserir(202);
            lista.inserir(402);

            lista.listar();

            while(!lista.isEmpty()) {
                int e = lista.retirar();
                Console.WriteLine("Retirei o elemento " + e);
            }
        }
    }
}