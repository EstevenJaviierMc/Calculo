using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo2
{
    class Program
    {
        //Se define metodo con el nombre TrapM y se le pasa el valor q tienen la variable "n" y los arreglos "x" y "fx", para calcular la integral
        static double TrapM(int n, double[] x, double[] fx)
        {
            //Se define la variable suma con un valor de 0
            double suma = 0;

            //Se suman todos los valores q tiene el arreglo "fx" y se guarda en la variable "suma"
            for (int i = 1; i < n; i++)
            {
                suma = suma + fx[i];
            }

            //Se calcula la integral mediante la formula
            double I = (x[n] - x[0]) * (fx[0] + 2 * suma + fx[n]) / (2 * n);

            //el metodo retorna el valor de la variable "I"
            return I;
        }

        static void Main(string[] args)
        {
            double b, a;
            do
            {
                //Pide al usuario el limite superior y lo guarda en la variable b
                Console.Write("ingrese limite superior: ");
                b = double.Parse(Console.ReadLine());


                //Pide al usuario el limite superior y lo guarda en la variable a
                Console.Write("ingrese limite inferior: ");
                a = double.Parse(Console.ReadLine());

                if (a > b)
                {
                    Console.Clear();
                    Console.WriteLine("El limite superior debe se mayor al limite inferior!");
                }

            } while (a > b);


            //Pide al usuario el limite el numero de datos a analizar y se guarda en la variable n
            Console.Write("ingrese numero de datos a analizar: ");
            int n = int.Parse(Console.ReadLine());

            //Se define el arreglo x 
            double[] x = new double[n + 1];

            //Se le da valor a H, restando el limite superior con el limite inferior y dividiendo el resultado entre n
            double h = (b - a) / n;

            //Se le asigna el valor del limite inferior en la posicion 0 del arreglo x
            //Y el valor del limite superior en la posicion n del arreglo
            x[0] = a;
            x[n] = b;

            //Asignandole valores a x2, x3 .... fn-1
            for (int i = 1; i < n; i++)
            {
                x[i] = x[i - 1] + h;
            }

            //Se define el arreglo fx
            double[] fx = new double[n + 1];

            //Asignandole valores a f1,f2, .... fn
            for (int i = 0; i < fx.Length; i++)
            {
                //Funcion que se nos asigno
                //fx[i]= Math.Pow( 8.1 + 12.5 * Math.Pow(x[i], 6) + 0.6 * x[i] + 10 * Math.Pow(x[i], 4) ,2);

                //Funcion que se da de ejemplo en el pdf dado por el profesor
                fx[i] = 0.2 + 25 * x[i] - 200 * Math.Pow(x[i], 2) + 675 * Math.Pow(x[i], 3) - 900 * Math.Pow(x[i], 4) + 400 * Math.Pow(x[i], 5);
            }

            Console.WriteLine("El valor de la integral es: " + TrapM(n, x, fx));//Se ejecuta el metodo TrapM

            Console.ReadKey();
        }
    }
}
