
using Varios;
using Varios.IBolillero;

namespace TestBolillero;

public class UnitTest1
{

    [Fact]
    public void TestBoli()
    {
        var bolillero = new Bolillero(10);
        Assert.Equal(10,bolillero.bolillas.Count);
    }
    public void TestSacarBolilla(Bolillero bolillero)
    {
        var bolilla=bolillero.SacarBolilla();
        Assert.Equal(0,bolilla);
        Assert.Equal(9,bolillero.bolillas.Count);
        Assert.Single(bolillero.Acertadas);
    }
}