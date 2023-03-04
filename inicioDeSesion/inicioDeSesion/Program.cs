using System;

class Registrarse
{
    public static string Registro(string nombreRegistro, string contrasenaRegistro)
    {
        Console.WriteLine("****************************************");
        return "******* Registrado correctamente *******";
        
    }
}

class IniciarSesion
{
    public static string inicioSesion(string nombre, string contrasena)
    {
        Console.WriteLine("*****************************************");
        return "*** Haz iniciado sesion correctamente ***";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese los datos que se le piden para registrarse.");
        Console.Write("Ingrese su nombre: ");
        string nombreRegistro = Console.ReadLine();

        Console.Write("Ingrese su contrasena: ");
        string contrasenaRegistro = Console.ReadLine();

        string registroExitoso = Registrarse.Registro(nombreRegistro, contrasenaRegistro);
        Console.WriteLine(registroExitoso);


        Console.WriteLine("Ingrese sus datos para poder iniciar sesion.");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("ingrese su contrasena: ");
        string contrasena = Console.ReadLine();

        if(nombreRegistro != nombre)
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*** nombre incorrecto! ***");
            Console.WriteLine("**************************");
        }
        if(contrasenaRegistro != contrasena)
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*** contrasena incorrecta! ***");
            Console.WriteLine("******************************");
        }
        if(nombreRegistro == nombre && contrasenaRegistro == contrasena)
        {
            string inicioExitoso = IniciarSesion.inicioSesion(nombre, contrasena);
            Console.WriteLine(inicioExitoso);
        }
    }
}

