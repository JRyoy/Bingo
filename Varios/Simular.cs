namespace Varios;

public class Simular
{
    public long simularSinHilos(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas)
    {
        var Aciertos=bolillero.JugadaNV(CantidadSimulacion,bolillas);
        return Aciertos;
    }
    long simularConHilos(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas)
    {
        
    }
}

