// Selection: Switch expression

char val = 'C';

string output = val switch
{
  'A' => "Letter is A",
  'B' => "Letter is B",
  _   => "Letter is something else"
});

Console.WriteLine(output);
