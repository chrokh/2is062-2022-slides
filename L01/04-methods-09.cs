// Med metodkomposition når vi en gräns.
// Metoder måste göras om till data för ökad abstraktion.
// Inte alltid trivialt.

char substituteChar (char input, (char, char)[] substitutions)
{
  foreach ((char, char) substitution in substitutions)
    if (substitution.Item1 == input)
      return substitution.Item2;
  return input;
}

string substituteString (string input, (char, char)[] substitutions)
{
  string output = "";
  foreach (char c in input) output += substituteChar(c, substitutions);
  return output;
}

(char, char)[] substitutions = new (char,char)[] {
  ('L','1'), ('E','3'), ('T','7'),
};

Console.WriteLine( substituteString("LEET", substitutions) );
