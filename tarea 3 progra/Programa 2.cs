using System;

namespace programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi,resultado,resultado2;
            pi = 3.1416;
            int rad,op,grad;

            Console.WriteLine("Ingrese la opcion que desee");
            Console.WriteLine("Opcion 1..Convertir de radianes a grados");
            Console.WriteLine("opcion 2..Convertir de grados a radianes");
            op = Convert.ToInt32(Console.ReadLine());
             
            switch (op) {
                case 1:
                    System.Console.WriteLine("ingrese la cantidad de radianes para acerlos a grados: ");
                    rad = Convert.ToInt32(Console.ReadLine());
                    resultado = rad * 188 / pi;
                    Console.Write("El result es: " + resultado);
                    break;
                case 2:
                    System.Console.WriteLine("Ingrese los grados para conver en radians");
                    grad = Convert.ToInt32(Console.ReadLine());
                    resultado2 = grad * pi / 180;
                    Console.Write("nEl resul es:" + resultado2);
                    break;
            }
            Console.WriteLine("Presione *Enter* Para finalizar y salir....");


        }
    }
}
