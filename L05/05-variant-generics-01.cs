// Abstract container
interface ICipher<in TIn, out TOut> // Variance!!
{
  TOut Encode (TIn input);
}

// Concrete container
class ConstantCipher<TIn,TOut> : ICipher<TIn,TOut>
{
  TOut k;
  public ConstantCipher (TOut k) => this.k = k;
  public TOut Encode (TIn input) => this.k;
}

// Contained data
abstract class Shape {}
class Circle : Shape {}


// Covariance
ICipher<string,Shape> cipher2 = new ConstantCipher<string,Circle>(new Circle());

// Contravariance
ICipher<Circle,string> cipher1 = new ConstantCipher<Shape,string>("");






