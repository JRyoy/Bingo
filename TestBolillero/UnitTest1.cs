
using Varios;

namespace TestBolillero;

public class UnitTest1
{
    [Fact]
    public void TestBoli(int CantidadBolillas)
    {
        var bolillero = new Bolillero(CantidadBolillas);
        Assert.Equal(10,bolillero.CantidadBolillas);
    }
}