class Cipher
{
  public delegate void EncodedEventHandler (string output);
  public event EncodedEventHandler Encoded;

  public string Encode (string input)
  {
    Console.WriteLine("Encoding...");
    System.Threading.Thread.Sleep(1000);
    string output = input;
    OnEncoded(output);
    return output;
  }

  public void OnEncoded (string output)
  {
    if (Encoded != null)
      Encoded(output);
  }
}

// Event handlers (tänk: observers)
void SendMail (string output) => Console.WriteLine("Sending mail: " + output);
void SendText (string output) => Console.WriteLine("Sending text: " + output);

// Main
Cipher cipher = new Cipher();

// Add listeners
cipher.Encoded += SendMail;
cipher.Encoded += SendText;
cipher.Encoded -= SendText;

cipher.Encode("hello");





