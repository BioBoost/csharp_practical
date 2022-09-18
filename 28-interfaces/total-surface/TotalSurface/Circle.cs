namespace TotalSurface
{
  class Circle
    {
    public Circle(double radius)
    {
      Radius = radius;
    }

    public double GetArea()
    {
      return Math.PI * Radius * Radius;
    }

    private double radius;
    public double Radius
    {
      get { return radius; }
      set { radius = Math.Abs(value); }
    }

    public override string ToString()
    {
      return $"<Circle> [radius = {Radius}]: {GetArea()} sq. meters";
    }
  }
}
