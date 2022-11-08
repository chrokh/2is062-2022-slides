// Deklaration
class Cat
{
}

//// Instansiering / konstruktion.
//new Cat();
//new Cat();


//// Tilldelning.
//Cat cat1 = new Cat();
//Cat cat2 = new Cat();

//// En klass definerar en typ.
//class Dog { }
//Dog dog1 = new Cat();


//// Uninitialized. Referns utan mål.
//Cat cat3;


//// Referenstyp. Default.
//Cat cat4 = null;


//// Ekvivalens.
//// Tänk: identiska kattungar.
//Cat cat5 = new Cat();
//Cat cat6 = new Cat();
//Console.WriteLine( cat5 == cat6 );


//// Flera referenser.
//Cat cat7 = new Cat();
//Cat cat8 = cat7;
//Console.WriteLine( cat7 == cat8 );


// Två till klasser.
//class Apple { }
//class Pear { }


//// Compile-time type.
//Type t1 = typeof(Apple);
//Type t2 = typeof(Pear);
//
//Console.WriteLine(t1);
//Console.WriteLine(t2);


//// Run-time type.
//Apple fruit1 = new Apple();
//Pear fruit2 = new Pear();
//
//Type t3 = fruit1.GetType();
//Type t4 = fruit2.GetType();


//// Typ-testning (inte typ-checkning).
//Apple fruit3 = new Apple();
//
//Console.WriteLine(
//  fruit3.GetType() == typeof(Apple)
//);
//Console.WriteLine(
//  fruit3.GetType() == typeof(Pear)
//);


// Exceptions är klasser.
//ArgumentException ex = new ArgumentException();
//throw ex;

// Instansiera och kasta direkt.
//throw new ArgumentException();


