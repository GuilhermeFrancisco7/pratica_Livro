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
            // Praticando Vetor
            int[] mate = new int[5];
            int[] cont = new int[4];
            int poscont, posmat;

            
            // Iniciando o loop for para recebimento dos valores no vetor

            Console.WriteLine("Digite Mate");

            for(posmat = 0; posmat < mate.Length; posmat++) 
            {
                mate[posmat] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Cont");

            for (poscont = 0; poscont < cont.Length; poscont++)
            {
                cont[poscont] = int.Parse(Console.ReadLine());
            }

            // Iniciando os loops de comparação 

            for (posmat = 0; posmat < mate.Length; posmat++)
            {

                for (poscont = 0; poscont < cont.Length; poscont++)
                {

                    if (mate[posmat] == cont[poscont])
                    {
                        Console.WriteLine($"Repitidos: {mate[posmat]}");
                        break;

                    }

                }
            }


           

          

        }
    }
}
