interface ICharToCharCipher {
  char Encode (char input);
}

interface IStringToStringCipher {
  string Encode (string input);
}

interface ICharToStringCipher {
  string Encode (char input);
}


class RobbersCipher : ICharToStringCipher, IStringToStringCipher {
  private char vowel;

  public RobbersCipher (char vowel)
    => this.vowel = vowel;

  public string Encode (char input) {
    string consonants = "BCDFGHJKLMNPQRSTVXYZ";
    if (consonants.IndexOf(Char.ToUpper(input)) != -1)
      return $"{input}{vowel}{input}";
    else
      return $"{input}";
  }

  public string Encode (string input) {
    string output = "";
    foreach (char letter in input)
      output += Encode (letter);
    return output;
  }
}
