Fält / Instansvariabler
=======================

- Objekt-specifika variabler.

- BOKSTÄVER PÅ BALLONGER.

- Algoritmer: Hitta alla ballonger med samma text.

- Måste deklareras med namn och typ i klassen.

```
┌────────────────────┐   ┌────────────────────┐
│ <class identifier> │   │       Circle       │
├────────────────────┤   ├────────────────────┤
│                    │   │ + Width : int      │
│    <attributes>    │   │ + Height : int     │
│                    │   │                    │
├────────────────────┤   ├────────────────────┤
│                    │   │                    │
│    <operations>    │   │                    │
│                    │   │                    │
└────────────────────┘   └────────────────────┘
```

- Access modifiers (`public`, `private`)

```
<class-identifier>
{
  <access-modifier> [static] <type> <identifier>;
}
```

- Get / set genom punkt-notation.
```
Ball ball = new Ball();
ball.Text = "Hej";
Console.WriteLine( ball.Text );
```

- `public` Bryter emot principen INFORMTATIONSGÖMNING.
  * (Breaking encapsulation)

- Ett fält kan innehålla andra objekt men det pratar vi om när vi kommer till KOMPOSITION.



