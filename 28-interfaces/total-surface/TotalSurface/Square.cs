namespace TotalSurface
{
  class Square
  {
    public Square(double side)
    {
      Side = side;
    }

    public double GetArea()
    {
      return Side * Side;
    }

    private double side;
    public double Side
    {
      get { return side; }
      set { side = Math.Abs(value); }
    }

    public override string ToString()
    {
      return $"<Square> [side = {Side}]: {GetArea()} sq. meters";
    }
  }
}
