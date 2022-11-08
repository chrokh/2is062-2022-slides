class CompositeCipher<T> : ICipher<T,T>
{
  ICipher<T,T> first, second;

  public CompositeCipher (
      ICipher<T,T> first,
      ICipher<T,T> second)
  {
    this.first = first;
    this.second = second;
  }

  public T Encode (T input)
    => second.Encode(first.Encode(input));
}



// Program 1
CompositeCipher<char> composite1 = new CompositeCipher<char>(
  new CaesarCipher(1),
  new LeetCipher());

Console.WriteLine(composite1.Encode('E'));



// Program 2
var caesars = new SubstitutionCipher(new CharToStringAdapter(new CaesarCipher(1)));
var leet = new SubstitutionCipher(new CharToStringAdapter(new LeetCipher()));

CompositeCipher<string> composite2 =
  new CompositeCipher<string>(caesars, leet);

Console.WriteLine(composite2.Encode("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));





















class CaesarCipher : ICipher<char,char>
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
}

class RobbersCipher : ICipher<char,string>
{
  private char vowel;

  public RobbersCipher (char vowel)
    => this.vowel = vowel;

  public string Encode (char input)
  {
    string consonants = "BCDFGHJKLMNPQRSTVXYZ";
    if (consonants.IndexOf(Char.ToUpper(input)) != -1)
      return $"{input}{vowel}{input}";
    else
      return $"{input}";
  }
}

class LeetCipher : ICipher<char,char>
{
  public char Encode (char input)
  {
    switch (input)
    {
      case 'L': return '1'; case '1': return 'L';
      case 'A': return '4'; case '4': return 'A';
      case 'O': return '0'; case '0': return 'O';
      case 'T': return '7'; case '7': return 'T';
      case 'E': return '3'; case '3': return 'E';
      default: return input;
    }
  }
}

interface ICipher<TIn, TOut>
{
  public TOut Encode (TIn input);
}

class SubstitutionCipher : ICipher<string,string>
{
  ICipher<char,string> cipher;

  public SubstitutionCipher (ICipher<char,string> cipher)
    => this.cipher = cipher;

  public string Encode (string input)
  {
    string output = "";
    foreach (char c in input)
      output += cipher.Encode(c);
    return output;
  }
}

class CharToStringAdapter : ICipher<char,string>
{
  ICipher<char,char> cipher;

  public CharToStringAdapter (ICipher<char,char> cipher)
    => this.cipher = cipher;

  public string Encode (char input)
    => cipher.Encode(input).ToString();
}
