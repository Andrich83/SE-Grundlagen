namespace Klasse_Taschenrechner;

public class Circle
{
  public int Radius;
  public Circle(int radius)
  {
    this.Radius = radius;
  }
  // D = Radius * 2
  public decimal Diameter()
  {
    return Radius * 2;
  }
  // 2 * Pi * R
  public decimal Circumference()
  {
    return Convert.ToDecimal(Math.PI) * 2 * Radius;
  }
  // Area = Pi * R^2
  public decimal Area()
  {
    return Convert.ToDecimal(Math.PI * Math.Pow(Radius, 2));
  }
}
