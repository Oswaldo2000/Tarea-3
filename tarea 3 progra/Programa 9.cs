using System;

namespace programa_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, totalmn = 0, totalmay = 0, edadmn, edadmay = 0, Suma = 0, i = 0;
            int ac = 0;

            Console.Write("Ingrese edad de persona:");
            edad = int.Parse(Console.ReadLine());
            edadmn = edad;
            for(int W = 2; W <= 6; W++)
            {
                ac = ac + edad;
            }
            while (edad > 0)
            {
                Suma = Suma + edad;
                i++;
                if (edad <= 17)
                    totalmn = totalmn + 1;
                else
                    totalmay = totalmay + 1;

                if (edad > edadmay)
                    edadmay = edad;
                if (edad > edadmn)
                    edadmn = edad;
                Console.Write("ingrese la edad:");
                edad = int.Parse(Console.ReadLine());
            }
            Console.Write("El promedio es:" + ac);
            Console.Write("Total de mn:" + totalmn);
            Console.Write("Total de may:" + totalmay);
            Console.Write("edad may:" + edadmay);
            Console.Write("edad mn:" + edadmn);

            Console.WriteLine("presione <enter> para salir..");
            Console.ReadKey();
        }
    }
}
