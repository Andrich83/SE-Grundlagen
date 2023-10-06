using System.Drawing;

namespace Klasse_Taschenrechner
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var num1 = 42;
      var num2 = 21;
      var result = Calculator.Add(num1, num2);
      var result2 = Calculator.Subtract(num1, num2);

      var factorialResult = Calculator.Factorial(6);

      Console.WriteLine(result);
      Console.WriteLine(result2);
      Console.WriteLine(factorialResult);

      Circle myCircle = new Circle(10);
      myCircle.Radius = 20;
      Console.WriteLine("MyCircle Area:\t" + myCircle.Area());
      Console.WriteLine("MyCircle Diameter:\t" + myCircle.Diameter());
      Console.WriteLine("MyCircle Circumference:\t" + myCircle.Area());

      int x = 5;
      int y = 5;
      Rectangle myRectangle = new Rectangle(x, y);
      Console.WriteLine("MyRectangle Area:\t" + myRectangle.Area());
      Console.WriteLine("MyRectangle Diameter:\t" + myRectangle.Diameter());
      Console.WriteLine("MyRectangle Circumference:\t" + myRectangle.Circumference());


    }
  }
}