using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keila
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, y;

            Console.WriteLine("Infome sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu peso: ");
            peso = double.Parse(Console.ReadLine());

            
            y = peso / (altura*altura);
            Console.WriteLine("Seu IMC é: " + y);


            Console.WriteLine("");
            Console.Read();
        }
    }
}
