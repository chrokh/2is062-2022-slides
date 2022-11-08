// Dynamic keyword and overloading

class Animal {}
class Cat : Animal {}
class Frog : Animal {}

static class Printer {
  public static void Print (Animal _) => Console.WriteLine("is Animal");
  public static void Print (Cat _)    => Console.WriteLine("is Cat");
  public static void Print (Frog _)   => Console.WriteLine("is Frog");
}

Animal x = new Cat();
Printer.Print(x as dynamic);
// Printer.Print("not-animal" as dynamic); // Run-time error!

