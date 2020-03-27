// ---------------------------------------------------------- Fonte: Dados6.cs
using System;
namespace Dados6
{
    class MainClass
    {
        const int SUCESSO = 0;
        const int LISTA_CHEIA = 1;
        const int LISTA_VAZIA = 2;
        
        // -------------------------------------------------- criaLista
        static void criaLista(int [] vetor) {
            vetor[0] = 0;
        }

        // -------------------------------------------------- incluiFim
        static int incluiFim(int tamanho, int [] vetor, int valor) {
            
            int numElementos = vetor[0];
            
            if (numElementos < tamanho-1)
            {
                vetor[0]++;
                vetor[vetor[0]] = valor;
                return(SUCESSO);
            }
            else
                return(LISTA_CHEIA);
        }
        
        // -------------------------------------------------- exibeLista
        static void exibeLista(int [] vetor) {
            
            String s = "";
            int tamanho = vetor[0];
            
            if (tamanho == 0)
                Console.WriteLine ("Erro: Lista Vazia", "Atenção");
            else
            {
                for (int i = 1; i <= tamanho; i++)
                    s = s + vetor[i] + " ";
                    Console.WriteLine ("Lista: " + s);
            }
        }

        public static void Main (string[] args)
        {

            const int tamanho = 7;
            int [] vetor = new int [tamanho];
            int valor;
            int erro = 0;
            
            criaLista(vetor);

            do {
                
                Console.Write ("Elemento: ");
                string elemento = Console.ReadLine();
                valor = Convert.ToInt32(elemento);
                
                if (valor != 0)                
                    erro = incluiFim(tamanho, vetor, valor);                    
                
                if (erro == LISTA_CHEIA)
                {
                    Console.WriteLine("Erro: Lista Cheia", "Atenção");
                    exibeLista(vetor);
                    return;
                }
            } while (valor != 0);
            
            exibeLista(vetor);
        }
    }
}