using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIMC
{
    class Program
    {
        //Questão 1
        static int Maior2(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        //Questão 3
        static bool Diferente(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)

        {
              //Questão 1 */

               Console.WriteLine(Maior2(8, 6));
               Console.ReadKey();
             //Questao 3
               Console.WriteLine(Diferente(7));
               Console.ReadKey();

              //IMC questao 2

                IMC IMCOBJETO = new IMC();
                Console.Write("digite o valor da sua altura :");
                double altura = double.Parse(Console.ReadLine());

                Console.Write("Digite o valor do seu peso :");
                double peso = double.Parse(Console.ReadLine());

                Double seuIMC = IMCOBJETO.calcular(peso, altura);

                Console.WriteLine("Seu IMC é :" + seuIMC);
                Console.WriteLine("Sua classificação é :" + IMCOBJETO.classificar(IMCOBJETO.calcular(peso, altura)));
                Console.ReadKey();          
        }
    }
}
