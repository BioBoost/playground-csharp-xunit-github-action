# Series of Squares

In de wiskunde worden heel wat speciale reeksen getallen gedefinieerd. De meeste gekende is waarschijnlijk de reeks van Fibonacci.

Een reeks is niet anders dan de som van een oneindige rij van getallen.

![Series](./img/series.png)

<!-- Latex: a_1 + a_2 + a_3 + ... = \sum_{i=0}^{\infty} a_i -->

Sommige eindige reeksen kunnen makkelijk worden uitgerekend aan de hand van een formule. Je hoeft dan niet altijd de volledige som te maken.

Als we de eindige reeks van kwadraten als volgt definiëren:

![Series of Squares](./img/series_of_squares.png)

<!-- Latex: 1^2 + 2^2 + 3^2 + ... + n^2 = \sum_{i=0}^{n} i^2 -->

Dan zou je de som als volgt kunnen berekenen:

![Formula](./img/formula.png)

<!-- Latex: 1^2 + 2^2 + 3^2 + ... + n^2 = \frac{n (n + 1) (2n + 1)}{6} -->

Natuurlijk moeten we dit uittesten of dit wel correct is.

Implementeer volgende methodes in de class `SquaredSeries`:

* `SeriesSum(int n)`: bepaal de som van de reeks der kwadraten door de kwadraten samen te tellen van de eerste `n` (inclusief) natuurlijke getallen. Start hierbij vanaf 1.
* `CalculateSumSeries(int n)`: bepaal de som van de reeks der kwadraten door bovenstaande formule toe te passen.

De `Main()` methode voorziet reeds een demo applicatie. In principe hoef je hier niets meer aan te passen.

**Probeer er voor te zorgen dat je project op het einde compileert. Desnoods zet je niet-werkende code in commentaar.**

Je vindt alle stappen als TODO's terug in Visual Studio onder `View => Task List`.

## Verwachte output

```text
Welcome to Series of Square

Let's determine the sum of the following series:
1^2 + 2^2 + 3^2 + 4^2 + 5^2

- Using summation: 55
- Using formula: 55

Super! The formula seems to be correct.
```

## Unit Tests

Het project wordt tevens vergezeld van Unit Tests. Gelieve deze te runnen.
