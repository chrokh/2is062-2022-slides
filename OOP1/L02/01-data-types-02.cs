//// Literaler och typer
//Console.WriteLine( "hej".GetType() );
//Console.WriteLine( 3.GetType()     );
//Console.WriteLine( true.GetType()  );


//// Compile-time type och run-time type
//string msg1 = "Hej";
//object msg2 = "Hej";
//
//Console.WriteLine( msg1.GetType() );
//Console.WriteLine( msg2.GetType() );


// Vänster-sidan och höger-sidan är bara en analogi.
// Alla värden har både en compile-time och run-time-typ.
object name1 = "chris";  // object och string
object name2 = name1;    // object och object

Console.WriteLine( name1.GetType() );
Console.WriteLine( name2.GetType() );


