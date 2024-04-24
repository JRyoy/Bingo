namespace Varios;

public class Simular
{
    public long simularSinHilos(Bolillero bolillero, int CantidadSimulacion, List<int> bolillas)
        => bolillero.JugadaNV(CantidadSimulacion, bolillas);
    public long simularConHilos(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas,long hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        long cantidadHilo=CantidadSimulacion/hilos;
        long res=CantidadSimulacion%hilos;
        for(long i=0 ;i<hilos; i++)
        {
            Bolillero Clon=bolillero.Clon(bolillero);

                tareas[0] = Task.Run(()=> Clon.JugadaNV(cantidadHilo+res,bolillas));
                tareas[i] = Task.Run(() => Clon.JugadaNV(cantidadHilo,bolillas));
        }
            Task.WaitAll(tareas);
            return tareas.Sum(t => t.Result);
        }
}


