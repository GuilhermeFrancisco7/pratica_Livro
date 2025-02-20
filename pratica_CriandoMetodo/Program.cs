using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_CriandoMetodo
{
    class Program
    {
        // Pratricando a criação de Métodos ( métodos são conjuntos de intruções que execultão suas funções 
        // ao sserem chamados/invocados dentro do escopo do static void Main.
        static void Main(string[] args)
        {
            
            int v1 = 10;
            int v2 = 52;
            Soma(v1, v2);
            Console.WriteLine(Soma(v1, v2));

        }
        static int Soma ( int v1,int v2)
        {
          
            int total = v1 + v2;
            return total;
        }
    }
}
