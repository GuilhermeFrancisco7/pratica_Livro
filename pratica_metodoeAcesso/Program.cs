using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_metodoeAcesso
{
    public class Jogador
    {
        public int energia ;
        public bool vivo;

        public Jogador()
        {
            energia = 100;
            vivo = true;
        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();
            Console.WriteLine(j1.energia);
        }
    }
}
