using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aruquivo_GITHUB
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome = "Gustavo";
            int idade = 0;

            Console.WriteLine("Digite sua idade: ");
            idade = Console.Read();

            if (idade > 20 && idade < 40)
            {
                Console.WriteLine("Gustavo é Jovem");

            }
            else {
                Console.WriteLine("O que é isso?");
            }
                Console.ReadKey();
            
        }
    }
}
