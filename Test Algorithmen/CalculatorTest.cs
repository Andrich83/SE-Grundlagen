using Klasse_Taschenrechner;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Test_Algorithmen;

public class CalculatorTest
{
  [Fact]
  public void TestCheckNumberIsPrimeNow()
  {
    var number = 5;
    Assert.Equal(true, Calculator.CheckNumberIsPrime(number));
  }
  [Fact]
  public void TestCheckNumberIsPrime()
  {
    var number = 5;
    Assert.Equal(true, Calculator.CheckNumberIsPrime(number));
  }
}
