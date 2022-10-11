interface ICipher<TIn, TOut>
{
  TOut Encode (TIn input);
}

class ConstantCipher<TIn,TOut> : ICipher<TIn,TOut>
{
  TOut k;
  public ConstantCipher (TOut k) => this.k = k;
  public TOut Encode (TIn input) => this.k;
}


var k1 = new ConstantCipher<char,char>('A');
Console.WriteLine(k1.Encode('b'));
Console.WriteLine(k1.Encode('!'));
Console.WriteLine(k1.Encode('z'));

var k2 = new ConstantCipher<char,string>("Hello");
Console.WriteLine(k2.Encode('b'));
Console.WriteLine(k2.Encode('!'));
Console.WriteLine(k2.Encode('z'));
