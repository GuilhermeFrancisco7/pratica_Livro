using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Declarando dois vetores 
            //int[] numeros = { 1, 2, 3, 4, 5 };
            //string[] nomes = { "Ana", "João", "Maria", "Carlos" };

            ////Exibindo os elementos do vetor com loop for
            //Console.WriteLine("Vetor de números (usando for):");
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            ////Exibindo os elementos do vetor de nomes com loop foreach
            //Console.WriteLine("\nVetor de Nomes (usando foreach):");
            //foreach (var nome in nomes)
            //{
            //Console.WriteLine(nome);
            //}


            // Vetor de números para ordenar
            int[] numeros = { 5, 3, 8, 4, 2 };

            // Mostra o vetor original
            Console.WriteLine("\n\nVetor Original:");
            ExibirVetor(numeros);

            Array.Sort(numeros);
            foreach (int i in numeros)
            {
                Console.Write(i + " ");
            }

            // Bubble Sort
            Console.WriteLine("\nVetor ordenado com Bubble Sort:");
            BubbleSort(numeros);
            ExibirVetor(numeros);

            Console.ReadLine();
        }

        // Função para exibir o vetor
        static void ExibirVetor(int[] vetor)
        {
            foreach (var numero in vetor)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        // Implementação do Bubble Sort
        static void BubbleSort(int[] vetor)
        {
            int n = vetor.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        // Troca os elementos
                        int temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }
        }    
    }
}
