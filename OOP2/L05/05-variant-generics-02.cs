interface ICipher<TIn, TOut> { // No variance in cipher here
  TOut Encode (TIn input);
}

interface IFactory<out T> { // Variance!
  T Next ();
  IEnumerable<T> Take (int n);
}

abstract class Factory<T> : IFactory<T> {
  public abstract T Next();
  public IEnumerable<T> Take (int n) {
    List<T> result = new List<T>();
    for (int i=0; i<n; i++)
      result.Add(Next());
    return result;
  }
}

class IncrementingCaesarCipherFactory : Factory<CaesarCipher> {
  int i = 0;
  public override CaesarCipher Next () => new CaesarCipher(i++);
}

class DecrementingCaesarCipherFactory : Factory<CaesarCipher> {
  int i = 0;
  public override CaesarCipher Next () => new CaesarCipher(i--);
}



// Covariance example 1:
IFactory<CaesarCipher> f1 = new IncrementingCaesarCipherFactory();
IFactory<ICipher<char,char>> f2 = new IncrementingCaesarCipherFactory();



// Covariance example 2:
IFactory<CaesarCipher> factory = new IncrementingCaesarCipherFactory();
print(3, factory);
printCaesar(3, factory);

void print (int n, IFactory<ICipher<char,char>> factory) {
  foreach (ICipher<char,char> cipher in factory.Take(n))
    Console.WriteLine(cipher.Encode('A'));
}

void printCaesar (int n, IFactory<CaesarCipher> factory) {
  foreach (CaesarCipher cipher in factory.Take(n))
    Console.WriteLine($"{cipher.Steps} => {cipher.Encode('A')}");
}






















class CaesarCipher : ICipher<char,char> {
  public int Steps { get; private set; }

  public CaesarCipher (int Steps)
    => this.Steps = Steps;

  public char Encode (char input)
  {
    string alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
    int i = alphabet.IndexOf(Char.ToUpper(input));
    int newIndex = (i + Steps) % alphabet.Length;
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
