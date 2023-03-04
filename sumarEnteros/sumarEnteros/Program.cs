using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int resultado = SumarEnteros();
            Console.WriteLine($"El total de la suma es: {resultado}");
        }
        catch (Exception e)
        {
            Console.WriteLine("El valor que ingreso no es un numero entero");
        }
        finally
        {
            Console.WriteLine("fin del programa");
        }
    }


    static int SumarEnteros()
    {
        Console.WriteLine("introduce los numeros enteros");

        Console.Write("Numero 1: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Numero : ");
        int numero2 = int.Parse(Console.ReadLine());

        int resultado = numero1 + numero2;
        return resultado;

    }
}