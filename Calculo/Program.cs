using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Program
    {

        static double Fx1(double x)
        {
            return Math.Sin(x);
        }

        static double trapecio(double A, double B, int N)
        {
            double Integral = 0;
            double h = (B - A) / N;
            for (double x = A; x < B; x += h)
            {
                double xdch = x + h;
                double Fx = Fx1(x);
                double Fxdch = Fx1(xdch);
                Integral += (Fx + Fxdch) / 2 * h;
            }
            return Integral;
        }
        static void Main(string[] args)
        {
            double Menor = 0.0, Mayor = Math.PI / 2.0;
            int Intervalos = 1000;
            double Ancho = (Mayor - Menor) / Intervalos;
            double Integral = (Fx1(Menor) + Fx1(Mayor)) / 2.0;
            for (int I = 1; I < Intervalos; I++)
            {
                Integral += Fx1(Menor + I * Ancho);
            }
            Integral *= Ancho;

            Console.WriteLine(Integral);
            Console.ReadLine();
        }
    }
}
