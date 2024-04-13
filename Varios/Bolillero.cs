namespace Varios;

public class Bolillero
{
    public static List<int>Bolillas { get; set; }
    
    public int CantidadBolillas { get; set; }
    public Bolillero(int CantidadBolillas)
    {
        Bolillas = new List<int>();
        for (int i = 0;i < CantidadBolillas;i++) { Bolillas.Add(i);}
    }
    public int SacarBolilla(List<int>Bolillas,Iazar izar)
    {
        izar.SacarBolilla(Bolillas);
        izar.Remove() ;
    }
}
