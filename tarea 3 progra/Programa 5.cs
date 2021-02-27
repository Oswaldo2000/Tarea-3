using System;

namespace programa_5
{
    class Programa_5
    {
        static void Main(string[] args)
        {
            int B, L, N, P, AP, A;
            System.Console.WriteLine("Ingrese una opcion");
            System.Console.WriteLine("1 sacar el perimetro de un triangulo regular");
            System.Console.WriteLine("2 Sacar el area de un triangulo regula");
            AP = Convert.ToInt32(Console.ReadLine());

            switch (AP)
            {
                case 1:
                    System.Console.WriteLine("Ingrese num de lados: ");
                    N = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Ingrese medida de lados: ");
                    L = Convert.ToInt32(Console.ReadLine());
                    P = L * N;
                    Console.Write("EL Perimt es: " + P);
                    break;
                case 2:
                    System.Console.WriteLine("Ingrese nperimt del triangulo: ");
                    P = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la Ap del triangulo: ");
                    B = Convert.ToInt32(Console.ReadLine());
                    A = P * B / 2;
                    Console.Write("El Area es de: " + A);
                    break;
                default:
                    Console.WriteLine("La opcion es Incorrecta");
                    break;

            }
            Console.WriteLine("Presione <enter> para salir..");
            Console.ReadKey();
            
        }
    }
}

