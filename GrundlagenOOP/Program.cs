namespace GrundlagenOOP
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");  // Statische-Klasse
      Random rng = new Random();  // Instanzierbare_Klasse
      //Cat myCat = new Cat();
      Cat myCat = new Cat("Minka", 10, "gelb");
      int x;
      Cat y;
      myCat.Miau();


      myCat.Name = "Minka";
      myCat.Age = 10;
      myCat.Color = "Silver-Tabby";
      Cat myCoolCat = new Cat("Minka", 10, "gelb");
      myCoolCat.Color = "Brown";
      myCoolCat.Age = 12;
      myCoolCat.Name = "Tom";
      Console.WriteLine(myCat);
      Console.WriteLine(myCoolCat);
      myCoolCat.Name = "Steffan";
      Console.WriteLine(myCoolCat);

      Cat jerry = new Cat("jerry", 8, "black");
      Console.WriteLine(jerry);
      jerry.Age += 1;

      jerry = new Cat("minka", 12, "silver");

      jerry.Miau();

      Cat.Schnurren();

      Console.ReadLine();
    }
  }
}
