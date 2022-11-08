Bridge Pattern
==============

- "Decouple an abstraction from its implementation so that the two can vary independently."
- Två lager av abstraktion.
- Skilja det plattformsspecifika ifrån det plattformsgenerella.

- Klassisk tolkning:
  * 2 typ-hierarkier.
  * Abstraktionen i ena has-a abstraktionen i andra.
  * Spotify-exemplet.

- Modern tolkning:
  * Konkreta klasser i vänstra has-a abstraktion i högra.
  * Strategy varierar implementationer, Bridge varierar abstraktioner.

- Exempel
  * Visa olika ciphers på olika sätt:
    - CipherView
      - ArrowView    (input -> output)
      - VerboseView  (Using <name> the input <input> translates to <output>)
  * Relatera exempel till deras spel.
