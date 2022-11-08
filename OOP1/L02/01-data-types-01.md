Datatyper
=========

- En datatyp definierar:
  1. En mängd värden.
  2. En mängd operationer som värdena tillåter.

## VÄRDEN

- Mängd (sets) / Typ:
  - `bool`
  - `int`
  - `char`
  - `int[]`
  - `bool[]`

- Värden och literaler:
  - `"hej"`  (`string`)
  - `3`      (`int`)
  - `true`   (`bool`)
  - Finns inte literaler för alla mängder.
  - Vi kan använda `GetType()` för att verifiera detta (nästa slide).

- Compile-time type + Run-time type
  - Typen som vi förväntar oss, och typen som vi faktiskt har.
  - Tänk: Vänster-sidan + höger-sidan
  - `string name = "chris";`  (`string` och `string`)
  - `int numApples = 4;`      (`int` och `int`)
  - `object name = "chris";`  (`object` och `string`)
  - Kör kod!!


## OPERATIONER

- En mappning ifrån en mängd till en mängd.
- Local functions, static methods, instance methods, operators
- Vi kan visualisera som funktioner över mängder.
- Increment
  * `inc :: int -> int`
  * `int Inc (int x, int y)`
- Addition
  * `(+) :: (int, int) -> int`
  * `static int operator +(int x, int y)`
