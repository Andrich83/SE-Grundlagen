namespace Klasse_Taschenrechner
{
  public class Rectangle
  {
    public int x, y;

    public Rectangle(int x, int y)
    {
      this.x = x;
      this.y = y;
    }


    // D² = A² + B²
    public decimal Diameter()
    {
      return ((x * x) + (y *y));
    }
    // C = 2x + 2y
    public decimal Circumference()
    {
      return Convert.ToDecimal((2 * x) + (2 * y));
    }
    // Area = x * y
    public decimal Area()
    {
      return Convert.ToDecimal(x * y);
    }
  }
}
