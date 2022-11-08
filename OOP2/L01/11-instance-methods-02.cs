class RobbersCipher {
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


// Olika state i olika instanser.
RobbersCipher c1 = new RobbersCipher('o');
RobbersCipher c2 = new RobbersCipher('a');

// Olika resultat med olika instanser.
Console.WriteLine(c1.Encode("Hello"));
Console.WriteLine(c2.Encode("Hello"));




