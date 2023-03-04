using System;
using System.Diagnostics.CodeAnalysis;

class OperacionesBasicas
{
    public static int Sumar(int a, int b)
    {
        return a + b;
    }
    public static int Restar(int a, int b)
    { 
        return a - b; 
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("No se puede dividir entre cero");
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Programa para calcular operaciones basicas *****");
        Console.Write("ingrese el primer numero entero: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("ingrese el segundo numero entero: ");
        int b = int.Parse(Console.ReadLine());

        int suma = OperacionesBasicas.Sumar(a, b);
        int resta = OperacionesBasicas.Restar(a, b);
        int multiplicacion = OperacionesBasicas.Multiplicar(a, b);
        int division = OperacionesBasicas.Dividir(a, b);

        Console.WriteLine($"La suma de {a} y {b} es: {suma}");
        Console.WriteLine($"La resta de {a} y {b} es: {resta}");
        Console.WriteLine($"La multiplicacion de {a} y {b} es: {multiplicacion}");
        Console.WriteLine($"La division de {a} y {b} es: {division}");
    }

}

