using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_Params
{
    class Program
    {
        static void Soma(params int[] num)
        {
            int res = 0;

            for(int i = 0; i < num.Length; i++)
            {
                res += num[i];
            }
            Console.WriteLine("Soma igual: {0}",res);
        }
        static void Main(string[] args)
        {
            Soma(1, 2, 3);

           
        }   

                 
    }
}
