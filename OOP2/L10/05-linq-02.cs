using System.Linq;
// EXTENSION METHODS

List<bool> bools = new List<bool>() { true, true, false };
List<int> ints = new List<int>() { 10, 20, 30, 40 };

Console.WriteLine( bools.And() );
Console.WriteLine( bools.Or() );


static class BoolExtensions
{
  public static bool And(this ICollection<bool> bools)
  {
    bool result = true;
    foreach (bool b in bools)
      result = result && b;
    return result;
  }

  public static bool Or(this ICollection<bool> bools)
    => bools.Aggregate(true, (acc, b) => acc || b);
}


