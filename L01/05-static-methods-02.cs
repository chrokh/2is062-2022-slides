static class ReverseCipher
{
  public static string Encode (string input)
  {
    string output = "";
    for (int i=input.Length-1; i>=0; i--)
      output += input[i];
    return output;
  }
}

Console.WriteLine(
  ReverseCipher.Encode("detneiro tcejbo ton"));

