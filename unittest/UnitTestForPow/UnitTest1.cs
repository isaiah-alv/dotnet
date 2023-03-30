using Xunit;
using PowerLibrary;
namespace unittest;

public class UnitTest1
{
    [Fact]
    public void Test2Nums()
    {
        double expected = 8;
        double actual = PowerLibrary.Power.PowerFunc(2,3);
        Assert.Equal(expected, actual);
    }
    public void Test3Nums()
    {
        double expected = 4095;
        double actual = PowerLibrary.Power.PowerFunc(2,3,4);
        Assert.Equal(expected, actual);
    }
}