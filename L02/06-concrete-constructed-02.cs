class FlipFlopCaesarCipher
{
  // OBJEKTKOMPOSITION eftersom instansfält.
  private CaesarCipher flip;
  private CaesarCipher flop;
  // KONKRET eftersom konkret compile-time typ.

  public FlipFlopCaesarCipher () {
    flip = new CaesarCipher(steps);
  }
  public FlipFlopCaesarCipher (int steps)
  {
    // KONSTRUERAD eftersom instansierad här.
    flip = new CaesarCipher(steps);
    flop = new CaesarCipher(-steps);
  }

  public string Encode (string input)
  {
    string output = "";
    for (int i=0; i<input.Length; i++)
      if (i % 2 == 0)
        output += flip.Encode(input[i]);
      else
        output += flop.Encode(input[i]);
    return output;
  }
}


// Main
FlipFlopCaesarCipher cipher = new FlipFlopCaesarCipher();
Console.WriteLine(cipher.Encode("AA BB CC"));























class CaesarCipher
{
  int steps;

  public CaesarCipher (int steps)
    => this.steps = steps;

  public char Encode (char input)
  {
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
    int i = alphabet.IndexOf(Char.ToUpper(input));
    int newIndex = (i + steps) % alphabet.Length;
    if (i != -1)
    {
      if (newIndex < 0)
        newIndex += alphabet.Length;

      if (Char.IsLower(input))
        return Char.ToLower(alphabet[newIndex]);
      else
        return alphabet[newIndex];
    }
    return input;
  }

  public string Encode (string input)
  {
    string output = "";
    foreach (char letter in input)
      output += Encode(letter);
    return output;
  }
}
