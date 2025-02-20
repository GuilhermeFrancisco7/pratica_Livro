using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praticaArray_metodos
{
    class Program
    {
        static void Main(string[] args)
        {//Praticando métodos para vertor
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[vetor1.Length +1];

            // preenchendo as posições do vetor unidimensional com números aleatórios!

            Random aleatorio = new Random();
            for(int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = aleatorio.Next(10);
            }
            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine(vetor1[i]);
            }

            

            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor2,1);
            foreach(var n in vetor2)
            {
                Console.WriteLine(n);
            }

        }
    }
}
