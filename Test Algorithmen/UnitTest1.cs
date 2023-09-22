using Algorhitmen;
namespace Test_Algorithmen
{
  public class UnitTest1
  {
    [Fact]
    public void TestLocateCard_DefaultCase()
    {
      int[] Karten = { 1, 2, 3, 4, 5 };
      int gesucht = 3;

      //int position = KartenAlgorithmus.FindedieKartenposition(Karten, gesucht);
      //Console.WriteLine(position==2);
      Assert.Equal(2, KartenAlgorithmus.FindedieKartenposition(Karten, gesucht));
    }
    [Fact]
    public void TestLocateCard_GesuchtnichtinKarten()
    {

      int[] Karten = { -1, 1 };
      int gesucht = 0;

      Assert.Equal(-1, KartenAlgorithmus.FindedieKartenposition(Karten, gesucht));

    }

    [Fact]
    public void TestLocateCard_DuplikategesuchteKarte()
    {
      int[] Karten = { 0, 1, 2, 3, 21, 21, 22, 23, 24, 69, 420, 1337};
      int gesucht = 21;

      Assert.Equal(4, KartenAlgorithmus.FindedieKartenposition(Karten, gesucht));
    }

    [Fact]
    public void TestLocateCard_CardisEmpty()
    {
      int[] Karten = {};
      int gesucht = 69;

      Assert.Equal(-1, KartenAlgorithmus.FindedieKartenposition(Karten, gesucht));
    }

    [Fact]
    public void TestLocateCard_BigArray()
    {
      int[] Karten = new int[1337];
      Random rand = new Random();

      for (int i = 0; i < Karten.Length; i++)
      {
        Karten[i] = rand.Next();
      }
      Karten[1336] = 420;
      Array.Sort(Karten);

      int gesucht = 420;

      var expectedPosition = Karten.ToList().FindIndex(x => x == gesucht);

      Assert.Equal(expectedPosition, KartenAlgorithmus.FindedieKartenposition(Karten, gesucht));
    }
  }
}