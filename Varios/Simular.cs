namespace Varios;

public class Simular
{
    public long simularSinHilos(Bolillero bolillero, int CantidadSimulacion, List<int> bolillas)
        => bolillero.JugadaNV(CantidadSimulacion, bolillas);
    public long simularConHilos(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas,long hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        long resultado=0;
        for(long i=0 ;i<hilos; i++)
        {
            Bolillero Clon=bolillero.Clon(bolillero);
            if(hilos%2==0)
            {
                tareas[i] = Task.Run(() => Clon.JugadaNV(CantidadSimulacion,bolillas));
            }
            else
            {
                tareas[i] = Task.Run(()=> Clon.JugadaNV());
            }
        }
            return resultado;
    }
}

