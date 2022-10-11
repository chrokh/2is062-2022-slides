// Abstrakta idén om ett kontrakt
class Coordinate
{
  public int X { get; set; }
  public int Y { get; set; }

  public Coordinate (int x, int y)
  {
    X = x;
    Y = y;
  }

  public void Add (Coordinate coord)
  {
    X += coord.X;
  }

  public void Translate (int x, int y)
  {
    X += x;
    Y += y;
  }
}
