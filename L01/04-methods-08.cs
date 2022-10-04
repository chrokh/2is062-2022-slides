// - Samma iteration i alla ciphers!
// - Vad skiljer sig?
//   * Parametrar
//   * Vilken char-metod
//   * Returtyp för char-metoden

string leetEncodeString (string input)
{
  string output = "";
  foreach (char letter in input)
    output += leetEncodeChar (letter);
  return output;
}

string caesarEncodeString (string input, int steps)
{
  string output = "";
  foreach (char letter in input)
    output += caesarEncodeChar (letter, steps);
  return output;
}



char caesarEncodeChar (char letter, int steps) => throw new NotImplementedException();
char leetEncodeChar (char letter) => throw new NotImplementedException();

