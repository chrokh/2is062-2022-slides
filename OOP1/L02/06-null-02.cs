// Kör i projekt med följande i .csproj
//   <Nullable>enable</Nullable>
//   <WarningsAsErrors>Nullable</WarningsAsErrors>

//string input = Console.ReadLine();
//
//if (false) {
//  string input = Console.ReadLine();
//}
//
//string? x = "Hello"; // Tagged: not-null
//string y = x;
//
//string? x = Console.ReadLine();
//string y = x;
//
//string? x = Console.ReadLine();
//string y;
//if (x != null)
//  y = x;
//
//False-positive
//string? x = "A";
//if (x == "B")
//  x = null;  // Körs aldrig, men ändå // maybe-null
//string y = x;
//
//string? x = "A";
//if (x == "B")
//  x = null;    // Körs aldrig!
//string y = x!; // Notera: !
//
// // False-negative
// TODO: Array-exempel
//string[] names = new string[10];
//string name = names[0].ToUpper();
//
//Console.WriteLine(names[0]);
//Console.WriteLine(names[0].Length);


