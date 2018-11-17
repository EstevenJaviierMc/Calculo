using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Program
    {
        static double trap(int n, double[] x, double[] fx, double t)
        {
            double suma = 0;
            for (int i = 1; i < n; i++)
            {
                suma = suma + fx[i];
            }
            double I = (x[n] - x[0]) * (fx[0] + 2 * suma + fx[n]) / (2 * t);
            return I;
        }

        static void Main(string[] args)
        {
            Console.Write("ingrese numero de datos a analizar: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("ingrese Ancho de los trapecios: ");
            double h = double.Parse(Console.ReadLine());

            int n = num;

            var x = new double[n];
            var fx = new double[n];

            Console.WriteLine("Introduce los datos");
            for (int i = 0; i < n; i++)
            {
                Console.Write("x[" + i + "]= ");
                x[i] = double.Parse(Console.ReadLine());

                Console.Write("fx[" + i + "]= ");
                fx[i] = double.Parse(Console.ReadLine());
            }
            //Ajueste respecto

            n = num - 1;
            double t = (x[n] - x[0]) / h;

            Console.WriteLine("El valor de la integral es: " + trap(n, x, fx, t));

            Console.ReadKey();
        }
    }
}
