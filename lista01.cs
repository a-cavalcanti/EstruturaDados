using System;

class Principal{

    static void questao1(){
        int soma = 0;
        for(int i =2; i<= 1000; i=i+2){
            soma+=i;
            soma = soma + i;            
        }
        for(int i =1; i<= 1000; i++){
            if (i%2 == 0)
            {
               soma+=i;
            }            
            soma = soma + i;
        }

        Console.WriteLine("Soma total: " + soma);
    }

    static void questao2(int fat){
        int mult = 1;
        for(int i = fat; i > 0; i--){
            mult *= i;
            //mult = mult * i;            
        }
        Console.WriteLine("Fatorial: " + mult);
    }

    static void questao3(){
        int[] vetor = new int[10]{5,6,20,1,2,3,150,-20,-30,400};

        float media, soma = 0f;
        int menor, maior;
        menor = vetor[0];
        maior = vetor[0];

        for (int i = 0; i < vetor.Length; i++)
        {
            if(vetor[i]< menor){
                menor = vetor[i];
            }
            if(vetor[i]> maior){
                maior = vetor[i];
            }
            soma += vetor[i];
        }
        media = soma/vetor.Length;
        Console.WriteLine("Menor: " + menor);
        Console.WriteLine("Maior: " + maior);
        Console.WriteLine("Média: " + media);

    }

    static int[] questao4(int[] vet1, int[] vet2){

        int[] vetor = new int[vet1.Length+vet2.Length];
        int pos = 0;

        for (int i = 0; i < vet1.Length; i++)
        {
            vetor[i] = vet1[i];
            pos=i;   
        }
        pos++;
        for (int i = 0; i < vet2.Length; i++)
        {
            vetor[i+pos] = vet2[i];   
        }
        return vetor;
    }

    static void imprimeVetor(int[] vet){
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine(vet[i]);
        }
    }

    static void imprimeMatriz(int[,] matriz){

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j] + " ");
            }
            Console.WriteLine("\n");
        }
    }

    static void questao6(int num){
        int[,] matriz = new int[num,num];
        int count = 0;
        for (int i = 0; i < num; i++)
        {            
            for (int j = 0; j < num; j++)
            {
                count++;
                matriz[i,j] = count;
            }
        }
        imprimeMatriz(matriz);
    }


    static void Main(){
        //questao1();
        //questao2(10);
        //questao3();


        /*int[] vetor1 = new int[3]{1,2,3};
        int[] vetor2 = new int[5]{900,800,700,600,500};
        int[] vetorFinal = new int[vetor1.Length+vetor2.Length];
        vetorFinal = questao4(vetor1, vetor2);
        imprimeVetor(vetorFinal);
        */
        
        

        questao6(2);
        questao6(3);
        questao6(4);

    }
}