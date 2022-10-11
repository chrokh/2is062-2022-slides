interface ICoordinate
{
  int X { get; set; }
  int Y { get; set; }
  void Translate (int x, int y);
}


class Coordinate : ICoordinate
{
  public int X { get; set; }
  public int Y { get; set; }

  public Coordinate (int x, int y) {
    X = x;
    Y = y;
  }

  public void Add (Coordinate coord) {
    X += coord.X;
  }

  public void Translate (int x, int y) {
    X += x;
    Y += y;
  }
}

// Program
//ICoordinate coord = new ICoordinate(); // Kompilerar ej!
ICoordinate coord = new Coordinate(0, 0);


