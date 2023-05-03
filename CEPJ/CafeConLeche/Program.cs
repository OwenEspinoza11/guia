using System;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Comenzando la preparación del café con leche...");

        // Paso 1: Hervir agua
        Console.WriteLine("Paso 1: Hervir agua");
        await HervirAgua();

        // Paso 2: Mezclar el café presto con agua caliente
        Console.WriteLine("Paso 2: Mezclar el café presto con agua caliente");
        await MezclarCafeEnPolvoConAguaCaliente();

        // Paso 3: Calentar la leche
        Console.WriteLine("Paso 3: Calentar la leche");
        await CalentarLeche();

        // Paso 4: Agregar la leche al café
        Console.WriteLine("Paso 4: Agregar la leche al café");
        await AgregarLecheAlCafe();

        //Paso 5: Agregar azúcar al gusto
        Console.WriteLine("Paso 5: Agregar azúcar");
        await AgregarAzucarAlCafe();

        Console.WriteLine("¡Listo! Disfruta tu café con leche.");
    }

    static async Task AgregarAzucarAlCafe()
    {
        Console.WriteLine("Agregando azúcar...");
        await Task.Delay(2000);
        Console.WriteLine("El azúcar se ha mezclado con el café con leche.");
        Console.WriteLine("");
    }

    static async Task HervirAgua()
    {
        Console.WriteLine("Comenzando a hervir agua...");
        await Task.Delay(5000);
        Console.WriteLine("El agua está hirviendo.");
        Console.WriteLine("");
    }

    static async Task MezclarCafeEnPolvoConAguaCaliente()
    {
        Console.WriteLine("Mezclando el café en polvo con agua caliente...");
        await Task.Delay(2000);
        Console.WriteLine("El café en polvo se ha mezclado con el agua caliente.");
        Console.WriteLine("");
    }

    static async Task CalentarLeche()
    {
        Console.WriteLine("Calentando la leche...");
        await Task.Delay(4000);
        Console.WriteLine("La leche está caliente.");
        Console.WriteLine("");
    }

    static async Task AgregarLecheAlCafe()
    {
        Console.WriteLine("Agregando la leche al café...");
        await Task.Delay(1000);
        Console.WriteLine("La leche se ha agregado al café.");
        Console.WriteLine("");
    }
}
