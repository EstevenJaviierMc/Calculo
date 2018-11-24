using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, f0, f1, f2, h, n, r, resultado, x1, x2, x3;
            do
            {
                Console.WriteLine("digite numero superior");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("digite numero inferior");
                a = Double.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.Clear();
                    Console.WriteLine("el numero superior debe se mayor al numero inferior");
                }
            } while (a >= b);

            Console.WriteLine("digite numero intervalo");
            n = Double.Parse(Console.ReadLine());

            // Para calcular altura
            h = (b - a) / n;
            // valor de la resta entre b y a
            r = b - a;
            // dandole valor a f0 multiplicando altura por cero
            f0 = 0 * h;
            // dandole valor a f1 dividiendo el limite superior entre 2
            f1 = b / 2;
            // asignandole el valor del limite superior a f2
            f2 = b;

            x1 = Math.Pow((8.1 + 12.5 * Math.Pow(f0, 6) + 0.6 * f0 + 10 * Math.Pow(f0, 4)), 2);
            x2 = Math.Pow((8.1 + 12.5 * Math.Pow(f1, 6) + 0.6 * f1 + 10 * Math.Pow(f1, 4)), 2);
            x3 = Math.Pow((8.1 + 12.5 * Math.Pow(f2, 6) + 0.6 * f2 + 10 * Math.Pow(f2, 4)), 2);

            resultado = (r * (x1 + 2 * x2 + x3)) / (2 * n);

            Console.WriteLine("resultado es= " + resultado);

            Console.ReadKey();
        }
    }
}
