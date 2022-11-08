Testability
===========

"Degree of effectiveness and efficiency with which test criteria can be established for a system, product or component and tests can be performed to determine whether those criteria have been met."

- Vi fokuserar på andra delen av ovan.

- Automated testing, key in continuous deployment

- Usually boils down to **isolation**, from
  1. Other code
    * (integration state explosion)
  2. Impurities
    * Impurity and non-determinism

- There's always at least two cases. The case you have + the test case.
  * Misko Hevery on Dependency Injection
