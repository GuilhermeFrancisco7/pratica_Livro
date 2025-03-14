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
            int num = 25;
            dobrar(ref num);
            Console.WriteLine(num);
         
        }
        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}
