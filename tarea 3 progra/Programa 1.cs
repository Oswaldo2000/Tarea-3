using System;

namespace Programa_1
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.Write("Ingrese un Numero:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 ==0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
            Console.WriteLine("Presiones *Enter* para salir...");
            Console.ReadKey();
        }
    }
}





