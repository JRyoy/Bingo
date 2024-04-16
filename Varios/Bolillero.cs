namespace Varios;

public class Bolillero
{
    public List<int> bolillas { get; set; }
    public List<int> Acertadas { get; set; }
    public Iazar iazar { get; set; }
    public Bolillero(int CantidadBolillas)
    {
        bolillas = new List<int>();
        for (int i = 0; i < CantidadBolillas; i++) { bolillas.Add(i); }
    }
    public int SacarBolilla()
    {
        var index = iazar.ObtenerIndice(this);
        int bolillaSacada = bolillas[index];
        Acertadas.Add(bolillaSacada);
        bolillas.RemoveAt(index);
        return bolillaSacada;
    }
    public bool Jugada(List<int> bolillas)
    {
        Restablecer();
        foreach (var bolilla in bolillas)
        {
            if (SacarBolilla() != bolilla) { return false; }
        }
        return true;
    }
    public int JugadaNV(int CantidadJugada, List<int> bolillas)
    {
        int Aciertos = 0;
        for (int i = 0; i < CantidadJugada; i++)
        { Jugada(bolillas); Aciertos += 1; }
        return Aciertos;
    }
    public void Restablecer()
    {
        bolillas.AddRange(Acertadas);
        Acertadas.Clear();
    }
}
