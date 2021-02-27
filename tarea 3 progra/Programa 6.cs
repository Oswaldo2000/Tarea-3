using System;

namespace programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            System.Console.WriteLine("Ingrese Un Num: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
                {
                Console.WriteLine(numero + "W" + i + "=" + (i * numero));
            }
            Console.WriteLine("Presiones <Enter> para finalizar");
            Console.ReadKey();
        }
    }
}
