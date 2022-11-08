interface ICharToCharCipher {
  char Encode (char input);
}

interface IStringToStringCipher {
  string Encode (string input);
}

interface ICharToStringCipher {
  string Encode (char input);
}


class CaesarCipher : ICharToCharCipher, IStringToStringCipher {
  int steps;

  public CaesarCipher (int steps)
    => this.steps = steps;

  public char Encode (char input) {
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

  public string Encode (string input) {
    string output = "";
    foreach (char letter in input)
      output += Encode(letter);
    return output;
  }
}
