using System;

namespace programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, total_pagar;
            String producto;
            Console.WriteLine("Ingrese nomb del produc");
            producto = Console.ReadLine();
            if (producto != "Café")
            {
                System.Console.WriteLine("Ingrese total de la compra:");
                total = Convert.ToInt32(Console.ReadLine());
                total_pagar = total * 0.12;
                Console.Write("La cantidad a pagar es de un total de:" + total_pagar);

            }
            else
            {
                System.Console.WriteLine("Ingrese total de la compr:");
                total = Convert.ToInt32(Console.ReadLine());

                Console.Write("La cantidad a pagar es de un total de:" + total);
            }
            Console.WriteLine("\n\npresiones <Enter> para salir y finis.");
            Console.ReadKey();
        }
    }
}