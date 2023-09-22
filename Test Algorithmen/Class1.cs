using Algorithmus;
namespace Test_Algorithmen;


public class MatheAlgorithmusTest
{
  [Fact]
  public void TestFaktorierungDefault()
  {
    var n = 5;
    var erwartet = 120;

    Assert.Equal(erwartet, MatheAlgorithmus.Fakturierung(n));


  }
  [Fact]

  public void Test_Faktorierung_Default()
  {
    var n = 8;
    var erwartet = 40_320;

    Assert.Equal(erwartet, MatheAlgorithmus.Fakturierung(n));
  }
}