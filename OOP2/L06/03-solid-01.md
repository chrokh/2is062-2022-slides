SOLID Principles
================

- Single responsibility principle
  * Single reason to change.

- Open-closed principle
  * Entities should be open for extension, but closed for modification.
  * "Never" rewrite code. Write new code, trash old dead code.
  * Fokuserade ursprungligen på inheritance, men numera på subtypning. Stabilt interface.

- Liskov substitution principle
  * Behavioral subtyping

- Interface segregation principle
  * No code should be forced to depend on methods it does not use.

- Dependency inversion principle
  1. High-level modules should not import anything from low-level modules. Both should depend on abstractions (e.g., interfaces).
  2. Abstractions should not depend on details. Details (concrete implementations) should depend on abstractions.
  (Ex: CompositeCipher -> ICipher, not CompositeCipher -> CaesarCipher)
  => ...

           CONSTRUCTED   INJECTED
CONCRETE      1             3
ABSTRACT      2             4

- Concrete dependency construction
- Abstract dependency construction
- Concrete dependency injection
- Abstract dependency injection
