using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cual es tu nombre");
        string nombre = Console.ReadLine();

        Console.WriteLine("Por favor escriba sus ingresos de los ultimos 3 meses");

        Console.Write("mes 1: ");
        double mes1 = double.Parse(Console.ReadLine());

        Console.Write("mes 2: ");
        double mes2 = double.Parse(Console.ReadLine());

        Console.Write("mes 3: ");
        double mes3 = double.Parse(Console.ReadLine());

        double suma = mes1 + mes2 + mes3;
        double promedio = suma / 3;

        Console.WriteLine($"Hola {nombre} en total ganaste Q.{suma} y el promedio es Q.{promedio}");
    }
}