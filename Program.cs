using System;

namespace ejemplo2_guia2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos las caracteristicas de la ventana
            Console.WindowHeight = 30;
            Console.WindowWidth = 70;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Titulo de la aplicación
            Console.Title = "Calculo de la cabuda de 3 amigos";
            Console.Write("\n Guía# 2 Ejemplo 2");
            Console.Write("\n\n");

            // Declaramos las variables
            Double c1, c2, c3, c4, p1, p2, p3, total;

            // Entrada de datos
            Console.Write("\t Calculando la cabuda de dinero");
            Console.Write("\n\n");
            Console.Write("\tIntroduzca la cantidad de Mbapee [dólares]....: $ ");
            c1 = Double.Parse(Console.ReadLine());
            Console.Write("\tIntroduzca la cantidad de Neymar [euros]......: e ");
            c2 = Double.Parse(Console.ReadLine());
            Console.Write("\tIntroduzca la cantidad de Melviño [dólares]...: $ ");
            c3 = Double.Parse(Console.ReadLine());
            Console.Write("\n");

            // Procesos
            c4 = c2 * 0.92;
            total = c1 + c4 + c3;
        }
    }
}

