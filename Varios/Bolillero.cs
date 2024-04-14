namespace Varios;

public class Bolillero
{
    public  List<int>bolillas { get; set; }
    public int CantidadBolillas { get; set; }
    public Iazar iazar{ get; set; }
    public Bolillero(int CantidadBolillas)
    {
        bolillas = new List<int>();
        for (int i = 0;i < CantidadBolillas;i++) { bolillas.Add(i);}
    }
    public int SacarBolilla()
    {
        var index = iazar.SacarBolilla(this);
        int bolillaSacada = bolillas[index];
        bolillas.RemoveAt(index);
        return bolillaSacada;
    }
    public bool Jugada(List<int>bolillas)
    {
        foreach(var bolilla in bolillas)
        {
            int bolillaSacada=SacarBolilla();
            if(bolillaSacada != bolilla){return false;}
        }
            return true;   

    }
    public int JugadaNV(List<int>bolillas,int CantidadJugada)
    {
        int Aciertos=0;
         for (int i = 0;i < CantidadJugada;i++)
        {   Jugada(bolillas); Aciertos+=1;}
        return Aciertos;
    }
}
