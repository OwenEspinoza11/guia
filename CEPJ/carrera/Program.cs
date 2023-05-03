//using System;

//public class Automovil
//{
//    private int kmph;
//    private string modelo;

//    public string Modelo { get => modelo; private set => modelo = value; }
//    public int Kmph { get => kmph; private set => kmph = value; }

//    public Automovil(string modelo)
//    {
//        Modelo = modelo;
//        Kmph = 0;
//    }

//    public string Encender()
//    {
//        return string.Format("El auto {0} ha sido encendido...", Modelo);
//    }

//    public void Acelerar(int valor)
//    {
//        Kmph = Kmph + valor;
//    }

//    public void Desacelerar(int valor)
//    {
//        Kmph = Kmph - valor;
//    }

//    public static void Main()
//    {
//        Automovil miAuto = new Automovil("Ford Mustang");
//        Console.WriteLine(miAuto.Encender());
//        Console.WriteLine("Velocidad inicial: " + miAuto.Kmph);

//        miAuto.Acelerar(30);
//        Console.WriteLine("Velocidad después de acelerar: " + miAuto.Kmph);

//        miAuto.Desacelerar(10);
//        Console.WriteLine("Velocidad después de desacelerar: " + miAuto.Kmph);

//        Console.ReadKey();
//    }
//}


using System;
using System.Threading.Tasks;

public class Automovil
{
    private int kmph;
    private string modelo;

    public string Modelo { get => modelo; private set => modelo = value; }
    public int Kmph { get => kmph; private set => kmph = value; }

    public Automovil(string modelo)
    {
        Modelo = modelo;
        Kmph = 0;
    }

    public string Encender()
    {
        return string.Format("El auto {0} ha sido encendido...", Modelo);
    }

    public void Acelerar(int valor)
    {
        Parallel.For(0, valor, i => Kmph++);
    }

    public void Desacelerar(int valor)
    {
        Parallel.For(0, valor, i => Kmph--);
    }

    public static void Main()
    {
        Automovil miAuto = new Automovil("Ford Mustang");
        Console.WriteLine(miAuto.Encender());
        Console.WriteLine("Velocidad inicial: " + miAuto.Kmph);

        miAuto.Acelerar(30);
        Console.WriteLine("Velocidad después de acelerar: " + miAuto.Kmph);

        miAuto.Desacelerar(10);
        Console.WriteLine("Velocidad después de desacelerar: " + miAuto.Kmph);

        Console.WriteLine("La carrera ha finalizado");

        Console.ReadKey();
    }
}
