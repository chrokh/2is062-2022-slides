delegate int Unary (int x);

int Inc (int x) => x + 1;
int Inv (int x) => -x;

Unary op1 = Inc;
Unary op2 = Inc;


// Generic
bool Not (bool a) => !a;

delegate T Unary<T> (T x);
Unary<int> op3 = Inc;
Unary<bool> op4 = Not;


// Built-in
Func<int,int> f1 = Inc;
Func<int,int> f2 = Inv;
Func<bool,bool> f3 = Not;
Action<string> a1 = Console.WriteLine;
// Varför inte alltid Func / Action?
// * Viss typ-säkerhet.
// * Ex: Som units. BTC istället för double.
// * Unary<int> != Func<int,int>


// Multicast
delegate void Operation ();

void Print1 () => Console.WriteLine("hello");
void Print2 () => Console.WriteLine("world");

Operation m1 = Print1;
Operation m2 = Print2;
Operation both = m1 + m2;
both += m2;



