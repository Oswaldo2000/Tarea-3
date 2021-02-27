using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, i;
            float resultado = 1;
            string lin;
            Console.Write("Ingrese Numero");
            lin = Console.ReadLine();
            numero = Int32.Parse(lin);
            for (i = 2; i <= numero; i++)
            {
                resultado = resultado * i;
            }
            Console.WriteLine("El factorial de {0} es {1}", numero, resultado);
            Console.WriteLine("Presione enter para salir..");
            Console.ReadKey();
        }

    }
}
