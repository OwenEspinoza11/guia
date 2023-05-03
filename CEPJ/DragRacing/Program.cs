public class Automovil
{
    private int kmph;
    private string modelo;

    public string Modelo { get => modelo; private set => modelo = value; }
    public int Kmph { get=> kmph; private set => kmph = value; }

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
        Kmph = Kmph + valor;
    }
    public void Desacelerar(int valor)
    {
        Kmph = Kmph - valor;
    }

    
}