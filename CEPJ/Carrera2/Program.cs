public class Automovil
{
    private int kmph;
    private string modelo;

    public string Modelo
    {
        get => modelo;
        private set => modelo = value;
    }

    public int Kmph
    {
        get => kmph;
        private set => kmph = value;
    }

    public Automovil(string modelo)
    {
        Modelo = modelo;
        Kmph = 0;
    }

    public string Encender()
    {
        return $"El auto {Modelo} ha sido encendido...";
    }

    public void Acelerar(int valor)
    {
        Parallel.For(0, valor, i => Kmph++);
    }

    public void Desacelerar(int valor)
    {
        Parallel.For(0, valor, i => Kmph--);
    }
}
