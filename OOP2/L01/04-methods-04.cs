// - En enkel metod.
// - Varför går inte att skriva som expression-bodied member?

string reverse (string input)
{
  string output = "";
  for (int i=input.Length-1; i>=0; i--)
    output += input[i];
  return output;
}

Console.WriteLine( reverse("desserts") );
Console.WriteLine( reverse("raw") );



