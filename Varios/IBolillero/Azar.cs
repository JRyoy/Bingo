namespace Varios.IBolillero;

public class Azar:Iazar
{
    public int ObtenerIndice(Bolillero bolillero)
    {
        Random random= new (DateTime.Now.Millisecond);
        return random.Next(bolillero.bolillas.Count);
    }
}
