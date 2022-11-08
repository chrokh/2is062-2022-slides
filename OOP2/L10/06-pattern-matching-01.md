
- Matcha:
  * Typer (ex: wolf meets sheep - simulation) (Multiple dynamic dispatch)
  * Värden (ex: int > 12, listors innehåll)
  * Kombination av båda.

- Vi kommer bara titta på att matcha typ idag. Se dokumentationen.

- I ett språk som stödjer pattern matching bör detta vara trivialt.

- Vad vill vi behålla:
  * Statisk typsäkerhet (kan vi skicka fel input?)
  * Exhaustiveness-check (har vi glömt att implementera en kombination?)

- C#: Matcha typ
  * Dictionary och switch (Key is type, value is value)
  * Dynamic keyword over method overloading (dynamic x = ...)
  * `is` och `switch` (C# pattern matching)
  * Visitor pattern

- C#: Matcha värden
  * `is` och `switch`

- Multiple dynamic dispatch med statisk typsäkerhet.
  - Endast Visitor pattern
