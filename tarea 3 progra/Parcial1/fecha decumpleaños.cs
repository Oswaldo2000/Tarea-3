using System;

namespace fecha_de_cumpleaños
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, multi1, multi2, suma1, suma2, resta, mes;
            int q, w, e, z;

            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Escriba la fecha de nacimiento: ");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("     ");
                Console.WriteLine("Ahora multipliquelo por 20");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                multi1 = numero * 20;

                Console.WriteLine("     ");
                Console.WriteLine("Al resultado sumale 73");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                suma1 = multi1 + 73;

                Console.WriteLine("     ");
                Console.WriteLine("Ahora multiplicalo por 5");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                multi2 = suma1 * 5;

                Console.WriteLine("     ");
                Console.Write("Ingrese el mes de tu cumpleaños: ");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sumale la fecha del mes de tu cumpleaños");

                suma2 = multi2 + mes;

                resta = suma2 - 365;

                Console.WriteLine("     ");
                Console.WriteLine("La fecha de tu cumpleaños es");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadKey();

                if (resta >= 1)
                {
                    if (resta <= 9999)
                    {
                        q = resta / 1000;
                        e = (resta % 1000) / 100;
                        w = (resta % 1000) % 100 / 10;
                        z = ((resta % 1000) % 100) % 100 / 1;
                        Console.WriteLine("La fecha de tu cumpleaños es: {0}{1}/{2}{3} ", q, e, w, z);
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Datos ingresados no validos");
                Console.ReadKey();
            }
        }
    }
}
