using System;

namespace Adivina_El_Numero_pensado
{
    class Program
    {
        static void Main(string[] args)
            {
            int numero, multipli, multipli2, suma, division, resta;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un numero cualquiera");
                numero = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Multiplique el Numero por 2 ");
            Console.ReadKey();

            multipli = numero * 2;
            Console.WriteLine("");
            Console.WriteLine("Ahora sumele 8 a su resultado");
            Console.ReadKey();
            suma = multipli + 8;
            Console.WriteLine("");
            Console.WriteLine("Al resultado multipliquelo 5");
            Console.ReadKey();
            multipli2 = suma * 5;
            Console.WriteLine(" ");
            Console.WriteLine("El resultado final es: {0}", multipli2);
            Console.WriteLine("Ahora procedere a adivinar tu numero");
            Console.ReadKey();

            division = multipli2 / 10;

            resta = division - 4;
            Console.WriteLine(" ");
            Console.WriteLine("El numero que usted penso es: {0}", resta);
            Console.ReadKey();
    
            
            }
        }
    }

