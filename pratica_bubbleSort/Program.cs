using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_bubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Praticando com Bubble Sort metodo e função

            int[] numeros = new int[5] { 2, 9, 7, 4, 0 };
            /* Array.Sort(numeros);
             foreach(int numero in numeros)
             {
                 Console.WriteLine(numero);
             } */
            BubbleSort(numeros);
            int Pos;
            for (Pos = 0; Pos < numeros.Length; Pos++)
            {
                Console.WriteLine(numeros[Pos]);
            }

        }
        static void BubbleSort(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for(int j = 0; j < vetor.Length - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }
    }
}
