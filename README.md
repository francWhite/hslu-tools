# Mathematik
## SquareAndMultiply
Berechnung der Modulo-Operation auf grossen natürlichen Potenzen:

a^b  mod x

### Beispiel

```
$> dotnet SquareAndMultiply.dll 1803 1291 2047
```
oder ohne Argumente:
```
$> dotnet SquareAndMultiply.dll
base: 1803
exponent: 1291
modulo: 2047
```

Resultat:

```
----------------------------------
| calculating 1803^1291 mod 2047 |
----------------------------------

exponent in binary: 10100001011
operations: (QM)QQMQQQQQMQQMQM
calculation: 1803--Q-->173--Q-->1271--M-->1020--Q-->524--Q-->278--Q-->1545--Q-->223--Q-->601--M-->740--Q-->1051--Q-->1268--M-->1752--Q-->1051--M-->1478

--------------------------------------
| Result : 1803^1291 mod 2047 = 1478 |
--------------------------------------
```

## Erweiterter euklidischer Algorithmus
Lösung einer Diophantischen Gleichung mit Hilfe des erweiterten Euklidischen Algorithmus

### Beispiel

```
$> dotnet ErweiterterEuklidischerAlgorithmus.dll 963 218
```
oder ohne Argumente:
```
$> dotnet ErweiterterEuklidischerAlgorithmus.dll
n: 963
m: 218
```

Resultat:

```
---------------------------------------------------------------
| Calculating ggT(963, 218) with extended euclidean algorithm |
---------------------------------------------------------------
963  -     1    0
218  4     0    1
 91  2     1   -4
 36  2    -2    9
 19  1     5  -22
 17  1    -7   31
  2  8    12  -53
  1  -  -103  455
------------------------------------------------------------
| ggT = 1, x = -103, y = 455 => 1 = -103 * 963 + 455 * 218 |
------------------------------------------------------------

```
