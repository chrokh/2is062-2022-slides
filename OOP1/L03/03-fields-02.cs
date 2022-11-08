//// Access genom punkt-notation.
//int[] numbers = new int[] { 10, 20, 30 };
//Console.WriteLine(numbers.Length);


// Deklaration
class Rectangle
{
  public int Width;
  public int Height;
}


//// Fält initialiseras till default.
//// Bli av med varning genom att explicit sätta värde.
//Console.WriteLine(new Rectangle().Width);
//Console.WriteLine(new Rectangle().Height);


//// Setting
//Rectangle r1 = new Rectangle();
//Rectangle r2 = new Rectangle();
//
//r1.Width  = 100;
//r1.Height = 50;
//
//r2.Width = 20;
//r2.Height = 10;
//
//// Kom ihåg: Bryter inkapsling!
//
//// Getting
//Console.WriteLine($"{r1.Width} x {r1.Height}");
//Console.WriteLine($"{r2.Width} x {r2.Height}");


//// Objekt som argument
//void printRectangle (Rectangle rect)
//  => Console.WriteLine($"{rect.Width} x {rect.Height}");
//
//Rectangle r3 = new Rectangle();
//
//r3.Width = 100;
//r3.Height = 200;
//
//printRectangle(r3);


// Object initializers
Rectangle r4 = new Rectangle { Width=10, Height=11 };
Rectangle r5 = new Rectangle { Width=20 }; // height?
// Behöver inte ange alla fält.
// Mer kompakt än att först instansiera och sen tilldela.


// Nytt exempel: Mutation
class Player
{
  public int X = 0;
  public int Y = 0;
  public string Name = "Unnamed";
}

void printPlayer (Player player)
  => Console.WriteLine($"{player.Name}: ({player.X},{player.Y})");


// Flytta en spelare
void movePlayer (Player player, string moves)
{
  foreach (char move in moves)
  {
    player.X += (move switch { 'E'=>1, 'W'=>-1, _=>0 });
    player.Y += (move switch { 'N'=>1, 'S'=>-1, _=>0 });
  }
}

Player p1 = new Player() { Name="Player1" };
Player p2 = new Player() { Name="Player2" };

movePlayer (p1, "SSSESE");
movePlayer (p2, "NNSWSEE");

printPlayer(p1);
printPlayer(p2);

// Detta är INTE instansmetoder! Ej OO!



