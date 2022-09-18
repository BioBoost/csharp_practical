namespace TotalSurface
{
  class AreaListing
  {
    public void Add(Square square) {
      squares.Add(square);
    }

    public void Add(Circle circle) {
      circles.Add(circle);
    }

    public double GetTotalArea() {
      double total = 0;

      foreach (var square in squares)
      {
        total += square.GetArea();
      }

      foreach (var circle in circles)
      {
        total += circle.GetArea();
      }

      return total;
    }

    public override string ToString()
    {
      string output = "";
      
      foreach (var square in squares)
      {
        output += square + "\n";
      }

      foreach (var circle in circles)
      {
        output += circle + "\n";
      }

      output += "------------------------------\n";
      output += $"Total Area: {GetTotalArea()} sq. meters";

      return output;
    }

    private List<Square> squares = new List<Square>();
    private List<Circle> circles = new List<Circle>();
  }
}