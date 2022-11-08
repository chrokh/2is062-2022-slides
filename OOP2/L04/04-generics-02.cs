// Non-generic
interface ICharToCharCipher {
  char Encode (char input);
}

interface IStringToStringCipher {
  string Encode (string input);
}

interface ICharToStringCipher {
  string Encode (char input);
}

// Generic
interface ICipher<TIn, TOut> {
  public TOut Encode (TIn input);
}

