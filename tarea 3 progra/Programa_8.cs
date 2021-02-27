using System;

namespace programa_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 3, div = 0;
            while (numero <= 1000)
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        div++;
                    }
                    if (div > 3)
                    {
                        break;
                    }
                }
                if (div == 3)
                {
                    Console.WriteLine("{0}", numero);
                }
                div = 0;
                numero++;
            }
            Console.WriteLine("Enter para salir");
            Console.ReadKey();
        }
    }
}
