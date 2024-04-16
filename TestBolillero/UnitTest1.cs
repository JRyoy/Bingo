
using Varios;
using Varios.IBolillero;

namespace TestBolillero;


public class UnitTest1
{
        public UnitTest1(Bolillero bolillero) 
        {
            this.bolillero = bolillero;
   
        }
            public Bolillero bolillero { get; set; }
    public UnitTest1() => bolillero = new Bolillero(10);
    [Fact]
    public void TestBoli()
    {
        Assert.Equal(10,bolillero.bolillas.Count);
    }
    [Fact]
    public void TestSacarBolilla()
    {
        var bolilla=bolillero.SacarBolilla();
        Assert.Equal(0,bolilla);
        Assert.Equal(9,bolillero.bolillas.Count);
        Assert.Single(bolillero.Acertadas);
    }
    [Fact]
    public void Reintegrar()
    {
        Assert.Equal(10,bolillero.bolillas.Count);
        Assert.Equal(0,bolillero.Acertadas.Count);
    }
    [Fact]
    public void TestJugarGana()
    {

    }

}