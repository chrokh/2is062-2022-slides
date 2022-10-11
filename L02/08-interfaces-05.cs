interface ICharToCharCipher {
  char Encode (char input);
}

interface IStringToStringCipher {
  string Encode (string input);
}

interface ICharToStringCipher {
  string Encode (char input);
}


class ReverseCipher : IStringToStringCipher
{
  public string Encode (string input)
  {
    string output = "";
    for (int i=input.Length-1; i>=0; i--)
      output += input[i];
    return output;
  }
}
