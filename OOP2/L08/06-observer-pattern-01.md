Observer pattern
================

- "Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically".

- Observable (Add, Remove, Notify)
- Observer (Notify)

- Exempel:
  * ObservableCipher
  * KeyStream

- Pub-Sub.
- Eliminerar inte polling men centraliserar.
- Ersätter poll med push ifrån perspektivet av observer.

(((
- Olika sätt att sen hämta data ifrån Observable:
  - Event args (also in .NET)
  - Skicka Observable (this).
  - Ha referens till Observable.
)))
