namespace Varios;

public class Bolillero
{
    public static List<int>bolillas { get; set; }
    
    public int CantidadBolillas { get; set; }
    public Bolillero(int CantidadBolillas)
    {
        bolillas = new List<int>();
        for (int i = 0;i < CantidadBolillas;i++) { bolillas.Add(i);}
    }
    public int SacarBolilla(List<int>bolillas,Iazar iazar)
    {
        int index = iazar.SacarBolilla(bolillas);
        int bolillaSacada = bolillas[index];
        bolillas.RemoveAt(index);
        return bolillaSacada;
    }
    public bool Jugada(List<int>jugada)
    {


    }
}
