using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUMEROPAR_IMPAR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 23;

            //Comprobamos si num es un número par o no
            if ((num % 2) == 0)
            {
                Console.WriteLine("El numero {0} es par", num);//Es un número par
            }
            else
            {
                Console.WriteLine("El numero {0} es: impar", num); //Es un número impar
            }

            
            Console.ReadLine();

        }

    }
}
