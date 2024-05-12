namespace Varios;

public class Simular
{
    public long SimularSinHilos(Bolillero bolillero, int CantidadSimulacion, List<int> bolillas)
        => bolillero.JugadaNV(CantidadSimulacion, bolillas);
    public long SimularConHilos(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas,long hilos)
    {

       var bolillero1 = bolillero.Clon(bolillero);
        Task<long>[] tareas = new Task<long>[hilos];
        long resto = CantidadSimulacion%hilos;
        for (long i = 0; i < resto; i++)
        {
            tareas[i] = Task.Run(() => bolillero1.JugadaNV(CantidadSimulacion / hilos, bolillas));
        }
        for (long i = resto; i < hilos; i++)
        {
            tareas[i] = Task.Run(() => bolillero1.JugadaNV(CantidadSimulacion / hilos, bolillas));
        }

        Task.WaitAll(tareas);
        return tareas.Sum(t => t.Result); 

        }
    public async Task<long> SimularConHilosAsync(Bolillero bolillero, int CantidadSimulacion,List<int> bolillas,long hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        long resto = CantidadSimulacion % hilos;
        for (long i = 0; i < resto; i++)
            tareas[i] =GenerarTask(bolillero, bolillas,CantidadSimulacion / hilos + 1);
        for (long i = resto; i < hilos; i++)
            tareas[i] =GenerarTask(bolillero, bolillas,CantidadSimulacion / hilos);

        await Task.WhenAll(tareas);
        return tareas.Sum(t => t.Result);
    }
    private static Task<long> GenerarTask(Bolillero bolillero, List<int> bolillas,long CantidadSimulacion)
    {
        var bolilleroClon = bolillero.Clon(bolillero);
        return Task.Run(()=>bolilleroClon.JugadaNV(CantidadSimulacion,bolillas));
    }
}


