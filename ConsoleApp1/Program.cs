using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, c; 
           

            Console.WriteLine("Введите x: "); 
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

           
            D = (Math.Tan(Math.Pow(x, 3) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) /
                    Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 4);
            D = Math.Round(D, 2); 
            Console.WriteLine($"Ответ: {D}");
        }
    }
    }
}
