interface ICharToCharCipher {
  char Encode (char input);
}

interface IStringToStringCipher {
  string Encode (string input);
}

interface ICharToStringCipher {
  string Encode (char input);
}



IStringToStringCipher cipher1 = new RobbersCipher('o');
IStringToStringCipher cipher2 = new CaesarCipher(1);
IStringToStringCipher cipher3 = new ReverseCipher();


// Interface segregation principle
// (går att implementera multipla interfaces)
