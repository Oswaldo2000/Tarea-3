using System;

namespace programa_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int B, E, A = 1;
            Console.Write("Ingrese la base de la Pot: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese poten:");
            E = int.Parse(Console.ReadLine());
            for (int i = 1; i <= E; i++) ;
            {
                A = A * B;
            }
            Console.Write("Result :" + A);
            Console.WriteLine("Presione <Enter> para salir..");
            Console.ReadKey();
        }
    }
}
