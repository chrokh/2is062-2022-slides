// Dictionary och switch
using System.Collections.Generic;

class Animal {}
class Cat : Animal {}
class Frog : Animal {}

static class Printer {
  public static void Print (Animal _) => Console.WriteLine("is Animal");
  public static void Print (Cat _) => Console.WriteLine("is Cat");
  public static void Print (Frog _) => Console.WriteLine("is Frog");
}

Dictionary<Type, Action<Animal>> actions
  = new Dictionary<Type, Action<Animal>>()
{
  { typeof(Animal), (Animal x) => Printer.Print((Animal)x) },
  { typeof(Cat),    (Animal x) => Printer.Print((Cat)x) },
  { typeof(Frog),   (Animal x) => Printer.Print((Frog)x) },
};


Animal x = new Cat();
actions[x.GetType()](x);
actions["foo".GetType()](x);
