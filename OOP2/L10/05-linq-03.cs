// Select, ForEach, Aggregate, Where, Reverse (reverse cipher)
using System.Linq;

List<int> xs = new List<int>() { 10, 20, 30, 40 };

// ForEach
//xs.ForEach(x => Console.WriteLine(x));

// Helper method
void print (IEnumerable<int> xs) => Console.WriteLine(String.Join(',', xs.ToList<int>()));

// Try helper method
//print(xs);

// Select
//var doubled = xs.Select(x => x * 2);
//print(doubled);

// Aggregate
//var sum = xs.Aggregate(0, (acc, x) => acc + x);
//Console.WriteLine(sum);

// Where
//var filtered = xs.Where(x => x > 20);
//print(filtered);

// Reverse
//IEnumerable<int> reversed = xs.Reverse().ToList<int>();
//print(reversed);

// Remember reverse cipher?
// Alla extension methods:
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=net-6.0
