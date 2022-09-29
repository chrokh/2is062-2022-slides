// Iteration: Reverse cipher

string input = "DOG";
string output = "";

for (int i=input.Length-1; i>=0; i--)
  output += input[i];

Console.WriteLine($"{input} => {output}");
