using System;
using  C = System.Console;

namespace _1_NumeroMayor
{
    class Program
    {
        /// Practica 1
        /// 1.- Encontrar el mayor de dos números.

        /// Chávez Pérez Melissa
        /// #M21210035


        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            //Variables
            string va;
            int num1, num2;

            C.WriteLine("\nFavor de ingresar el primer numero ");
            va = C.ReadLine();
            num1 = int.Parse(va);

            C.WriteLine("\nFavor otro numero ");
            va = Console.ReadLine();
            num2 = int.Parse(va);

            //cant = int.Parse(C.ReadLine());
           if (num1 > num2)
            {
                C.WriteLine("El primer numero es mayor: " + num1);
            }
            else 
            {
                if(num2 > num1)
                {
                    C.WriteLine("El segundo numero es mayor:" + num2);
                }
                else
                {
                    C.WriteLine("Los numero son iguales");
                }
            }

            Console.ReadKey();
        }
    }
}
