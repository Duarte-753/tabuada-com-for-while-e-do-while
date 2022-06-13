using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_com_for__while_e_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Nome: Julio Duarte Batista RA:6322046

            int i, final, inicio, total, tabuada;

            Console.WriteLine("Qual a tabuada: ");
            tabuada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o número de inicio: ");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o número final: ");
            final = Convert.ToInt32(Console.ReadLine());

            /*
            for (i = inicio; i <= final; i++)
            {
                total = inicio * i;
                Console.WriteLine(tabuada + " X " + i + " = " + total);
            }*/


            /*
            while (inicio < final + 1)
            {
                i = inicio++;

                total = inicio * i;
                Console.WriteLine(tabuada + " X " + i + " = " + total);
                if (i == final)
                    break;

            }*/

            do
            {
                i = inicio++;

                total = inicio * i;
                Console.WriteLine(tabuada + " X " + i + " = " + total);
                if (i == final)
                    break;
            } while (inicio < final + 1);
        }
    }
}
