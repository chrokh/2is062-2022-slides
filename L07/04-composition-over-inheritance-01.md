Composition over inheritance
============================

- Code reuse through composition, not inheritance.

- Problem:
  - Dela kod "åt sidan" / överlapp.
  - Förändra beteende vid "run-time".

- Before
  - Duck
    * string Quack ()
    * string Fly ()
  - MallardDuck : Duck
  - RubberDuck : Duck
  - RocketDuck : Duck

- After
  - IDuck
    * IQuackBehavior quackBehavior;
    * IFlyBehavior flyBehavior;
    * string Quack ()
    * string Fly ()
  - IQuackBehavior
    * string Quack ()
  - IFlyBehavior
    * string Fly ()

