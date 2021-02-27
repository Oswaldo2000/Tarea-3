using System;

namespace programa_4
{
    class Programa_4
    {
        static void Main(string[] args)
        {
            int dia;
            System.Console.WriteLine("Ingrese Num:");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domi");
                    break;
                case 2:
                    Console.WriteLine("Lun");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Mierco");
                    break;
                case 5:
                    Console.WriteLine("Juev");
                    break;
                case 6:
                    Console.WriteLine("Viern");
                    break;
                case 7:
                    Console.WriteLine("Sábad");
                    break;
                case 8:
                    Console.WriteLine("Semana finalizada");
                    break;

                default:
                    Console.WriteLine("Numero sin datos invalido");
                    break;
            }
            Console.Write("Presione para seguir.");
            Console.ReadKey();
        }
    }
}
