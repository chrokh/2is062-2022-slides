Fail fast
=========

- Fel måste fram så fort som möjligt.
- Ju snabbare vi upptäcker ett fel, desto lättare är det att fixa det.
- Exempel: Felformatterat telefonnummer.
  * När användaren skriver in det.
  * När vi försöker skicka 2FA till användaren en månad senare.

- Två konsekvenser:

  1. Dåliga värden ska inte propageras. Kasta exception!
    * Lokala fel är enklare att hantera.

  2. Föredra kompilerings-fel över exekveringsfel.

- Exempel: Du ska klättra upp för en stege som ser ranglig ut.
  1. Exekveringsfel: Vill du att den går sönder när du är lågt eller högt?
  2. Kompileringsfel: Bättre om vi kan analysera stegen och bedöma att den inte håller.


