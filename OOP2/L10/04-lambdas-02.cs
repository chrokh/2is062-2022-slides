// Exempel
//Action line = () => Console.WriteLine();
//Func<int, int> inc = x => x+1;
//Func<int, int> dec = x => x-1;

// => Används även för expression-bodied members och därmed local functions som inte är samma sak.
//int inc (int x) => x + 1; // Local function, inte lambda!

// Expression-lambda vs statement-lambda
//Func<int,int> square = x => x*x; // Expression lambda
//Action<int> lines = (x) => { // Statement lambda
//  for (int i=0; i<x; i++)
//    Console.WriteLine();
//};

// Type inference:
//var square = (x) => x*x;        // Inferrerad typ av uttrycket.
//Func<int,int> square = (int x) => x*x;  // Explicit parameter-typ, inferrerad retur-typ.

// Natural type: (Inferrad delegat-typ)
//var square = (int x) => x*x;
//var square = (x) => x*x;

 //Kan inte alltid inferera parametrarnas typ.
//var print = x => Console.WriteLine(x);
//var print = (string x) => Console.WriteLine(x);
//Action<string> print = x => Console.WriteLine(x);

 //Kan inte alltid inferera retur-typ:
//var choose = (bool b) => b ? 1 : "two";
//var choose = object (bool b) => b ? 1 : "two";
//Func<bool,object> choose = b => b ? 1 : "two";

// Ingen parametrisk polymorfism
//var konst = (x, _) => x;
//var id = x => x;
//var ifelse = (bool c, x, y) => c ? x : y;
// To implement these you need to use "local functions".

//T ifelse<T> (bool c, T l, T r) => 


// Finns ingen intern typ som är Lambda expression. Behöver lagras i en variabel av delegat-typ eller instans av LambdaExpression eller Expression<TDelegate>.
