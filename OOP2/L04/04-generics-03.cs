// VÅRT INTERFACE
interface ICipher<TIn, TOut>
{
  public TOut Encode (TIn input);
}


// ETT CIPHER
class IdentityCipher<T> : ICipher<T, T>
{
  public T Encode (T input) => input;
}


// PROGRAM
IdentityCipher<int> id = new IdentityCipher<int>();
Console.WriteLine( id.Encode("hello") );


