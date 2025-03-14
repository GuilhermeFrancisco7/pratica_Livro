using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_metodoTabuada
{
    class Program
    {// Criando um Método/Função para gerar uma tabúada

        static void Tabuada(int n1) // Método/Função criada para gerar a tabuada
        {
           

            Console.WriteLine("Tabuada do número {0}, Selecionada!", n1); // imprime na tela do usuário
            for (int i=0; i <= 10; i++) // laço For para criar a tabúada de  0 até 10
            {
               int res =n1 * i;
                Console.WriteLine(" Número {0} vezes o {1} é : {2}",n1,i,res); // imprime na tela o resultado
              
 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dígite um Número  para selecinar a tabuada!");
            
            int v1 = int.Parse(Console.ReadLine()); // recebe o valor dígitado pelo usuário
         
            bool si= true; // variável Booleana para controlar o laço While 
            
            
            while (si) // laço de repetição while, acionado enquanto valor de bool 'si' for 'Verdadeiro'
            {
              
                Tabuada(v1); // invocação/execução do metodo " o conjunto de intruções progamadas"
                Console.WriteLine("Continuar com outra tabúada digite (Sim/Não)");
                string nova = Console.ReadLine().ToUpper(); // recebe a resposta se o usuário  quer continuar
                Console.Clear(); // apaga a tela com a tabuada anterior feita com a execução do método
                

                if (nova == "SIM") // estrutura de controle IF para repetição da execução do Loop While e do Método
                {
                    Console.WriteLine("Dígite um Número  para selecinar a tabuada!");

                     v1 = int.Parse(Console.ReadLine());
                    
                }
                else  // estrutura ELSE para interromper o Loop e a ativação do Método
                { si = false; } // troca o valor da Variável Bool si para 'FALSO', parando o loop While.
            }
            
        }
    }
}
