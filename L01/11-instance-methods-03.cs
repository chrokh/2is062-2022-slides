class CaesarCipher {
  int steps;

  public CaesarCipher (int steps)
    => this.steps = steps;

  public char Encode (char input) {
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
    int i = alphabet.IndexOf(Char.ToUpper(input));
    if (i == -1) return input;
    int remainder = (i + steps) % alphabet.Length;
    int newIndex = remainder >= 0 ? remainder : remainder + alphabet.Length;
    char output = alphabet[newIndex];
    return Char.IsLower(input) ? Char.ToLower(output) : output;
  }

  public string Encode (string input) {
    string output = "";
    foreach (char letter in input)
      output += Encode(letter);
    return output;
  }
}

// Olika state i olika instanser.
CaesarCipher addTwo = new CaesarCipher(2);
CaesarCipher subOne = new CaesarCipher(-1);

// Olika resultat med olika instanser.
Console.WriteLine(addTwo.Encode("ABC"));
Console.WriteLine(subOne.Encode("ABC"));


