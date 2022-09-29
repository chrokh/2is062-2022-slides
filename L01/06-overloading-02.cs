static class RobbersCipher
{
  public static string Encode (char input, char vowel)
    => input switch {
      'B' or 'b' or 'C' or 'c' or 'D' or 'd' or 'F' or 'f' or 'G' or 'g' or 'H' or 'h' or 'J' or 'j' or 'K' or 'k' or 'L' or 'l' or 'M' or 'm' or 'N' or 'n' or 'P' or 'p' or 'Q' or 'q' or 'R' or 'r' or 'S' or 's' or 'T' or 't' or 'V' or 'v' or 'W' or 'w' or 'X' or 'x' or 'Y' or 'y' or 'Z' or 'z'
        => $"{input}{vowel}{input}",
        _ => $"{input}"
    };

  public static string Encode (string input, char vowel)
  {
    string output = "";
    foreach (char letter in input)
      output += Encode (letter, vowel);
    return output;
  }
}

Console.WriteLine(RobbersCipher.Encode('d', 'a'));
Console.WriteLine(RobbersCipher.Encode("bird", 'o'));

// Varför inte endast variera retur-typ?
