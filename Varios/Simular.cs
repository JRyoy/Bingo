namespace Varios;

public class Simular
{
    public long simularSinHilos(Bolillero bolillero, int CantidadSimulacion, List<int> bolillas)
        => bolillero.JugadaNV(CantidadSimulacion, bolillas);
    public long simularConHilos(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas,int hilos)
    {
        Task<int>[] tareas = new Task<int>[hilos];
        for(long i=0 ;i<hilos; i++)
        {
            Bolillero Clon=bolillero.Clon(bolillero);
            
        }
    }
}

