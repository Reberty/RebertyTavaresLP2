using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int  max, div;

            

            Console.WriteLine("informe o número máximo");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("informe o divisor");
            div = int.Parse(Console.ReadLine());

            for (int i = div; i <= max; i+=div)
            {
               

               
                if(i % div == 0)
                {
                    Console.WriteLine(" é multiplo de {0} !", i );
                }
            }
            Console.ReadKey();
        }
    }
}
