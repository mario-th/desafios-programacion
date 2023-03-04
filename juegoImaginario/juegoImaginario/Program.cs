using System;

class Program
{
    static int puntuacionMaxima = 0;
    static string jugadorRecord = "";

    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al juego.");

        while (true)
        {
            Console.Write("Introduce tu nombre: ");
            string nombreJugador = Console.ReadLine();

            Console.Write("Introduce tu puntuación: ");
            int puntuacion = int.Parse(Console.ReadLine());

            ActualizarPuntuacion(nombreJugador, puntuacion);
        }
    }

    static void ActualizarPuntuacion(string nombreJugador, int puntuacion)
    {
        if (puntuacion > puntuacionMaxima)
        {
            Console.WriteLine("La nueva puntuación más alta es " + puntuacion);
            Console.WriteLine("La puntuación más alta fue lograda por " + nombreJugador);
            puntuacionMaxima = puntuacion;
            jugadorRecord = nombreJugador;
        }
        else
        {
            Console.WriteLine("La puntuación más alta de " + puntuacionMaxima + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
        }
    }
}
