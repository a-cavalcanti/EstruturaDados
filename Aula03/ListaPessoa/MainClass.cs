using System;

namespace Aula03_ListaPessoa
{
    class MainClass 
    {

        static void Main(string[] args) {
            ListaSimples lista = new ListaSimples();
            
            Pessoa p = new Pessoa();
            p.setNome("João");
            p.setIdade(20);
            p.setSexo("M");
            
            Pessoa p2 = new Pessoa();
            p2.setNome("José");
            p2.setIdade(30);
            p2.setSexo("M");
            lista.inserirPrimeiro(p);
            lista.inserirPrimeiro(p2);
            
            lista.imprimirLista();
            
            lista.removerNodo("João");
            
            lista.imprimirLista();

        }

    }
    
}