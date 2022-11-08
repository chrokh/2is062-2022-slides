#nullable enable
// is och switch

// Null-checks
//int? maybe = 12;
//int x;
//if (maybe is int number) {
//  Console.WriteLine(number);
//  Console.WriteLine(maybe);
//  //x = number;
//  //x = maybe;
//}


//string? maybe = "abc";
//string x;
//if (maybe is not null)
//  x = maybe;



// Type test using is
//class Animal {}
//class Cat : Animal {}
//class Frog : Animal {}
//
//Animal a = new Cat();
//
//if (a is Cat c)
//  catMethod(c);
//else if (a is Frog f)
//  frogMethod(f);
//
//void catMethod (Cat _) => Console.WriteLine("Meow");
//void frogMethod (Frog _) => Console.WriteLine("Frog");


// Type test using switch expression
//class Animal {}
//class Cat : Animal {}
//class Frog : Animal {}
//
//Animal a = new Cat();
//
//string output = a switch
//{
//  Cat c => catMethod(c),
//  Frog f => frogMethod(f),
//};
//
//string catMethod (Cat _) => "Meow";
//string frogMethod (Frog _) => "Frog";


