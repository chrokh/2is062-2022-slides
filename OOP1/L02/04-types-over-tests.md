Types over tests
================

- Är `string` en bra modell för:
  * Telefonnummer?
  * E-post?
  * Bostadsadresser?

> Testing is good. Impossible is better. -- Richard Feldman.
> Make illegal states unrepresentable -- Yaron Minsky.
> Make impossible states impossible -- Richard Feldman.

- Exempel
  - Telefonnummer
  - Personnummer (utbytesstudenter?)
  - Valuta (SEK, BTC, EUR)
  - Vokaler
  - Enheter: Längd, Tid, Massa
  - Härledda enheter: Hastighet
    - Mars droid 1999. Satellit. Kretslopp. Assymetrisk design. Banan behövde korrigeras regelbundet.
    - Blandade metersystemet och Brittiska systemet (imperial).
    - (rymdsond)

- Bijection rule
  - Every object in our model should map to a single concept in our domain, and vice versa.
  - Every distinct element in A is mapped to a distinct element in B and vice versa.
  - Total function.

- Sammanfattning
  1. Alla värden i våra typer måste mappa mot ett koncept.
  2. Alla mappade koncept måste vara meningsfulla.
