# Vad är problemet med konkret konstruerad?

- Konstruktor-argument måste dupliceras "hela vägen upp".

KLASS:      A -> B -> C -> D
EGNA ARG:   2    2    2    2
TOT ARG:    8    6    4    2

Om D förändras så måste alla andra förändras!

Don't repeat yourself!

