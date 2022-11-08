class RobbersCipherVowel
{
  public char Vowel;
  public RobbersCipherVowel (char vowel)
  {
    Vowel = vowel switch {
      'A' or 'a' or 'E' or 'e' or 'I' or 'i' or 'O' or 'o' or 'U' or 'u'
        => vowel,
      _ => 'o'
    };
  }
}


// Försöker skapa med konsonant
RobbersCipherVowel certainlyVowel
  = new RobbersCipherVowel('K');

// Men konstruktorn ser till att det inte går.
Console.WriteLine(certainlyVowel.Vowel);

// Tyvärr är ju fältet fortfarande publikt.
//certainlyVowel.Vowel = 'K';
//Console.WriteLine(certainlyVowel.Vowel);



