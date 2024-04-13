namespace Varios.IBolillero;

public class Azar
{
    public int SacarBolilla(List<int>Bolillas)
    {
        Random random= new Random();
        return random.Next(Bolillas.Count);
    }
}
