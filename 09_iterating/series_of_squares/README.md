# Series of Squares

Many special sets of numbers are defined in mathematics. The most known is probably the Fibonacci sequence.

A sequence is defined as the sum of an infinite sequence of numbers.

![Series](./img/series.png)

<!-- Latex: a_1 + a_2 + a_3 + ... = \sum_{i=0}^{\infty} a_i -->

Some finite series can be easily calculated using a formula. You do not always have to make the full sum.

If we define the finite series of squares as follows:

![Series of Squares](./img/series_of_squares.png)

<!-- Latex: 1^2 + 2^2 + 3^2 + ... + n^2 = \sum_{i=0}^{n} i^2 -->

Then you could calculate the sum as follows:

![Formula](./img/formula.png)

<!-- Latex: 1^2 + 2^2 + 3^2 + ... + n^2 = \frac{n (n + 1) (2n + 1)}{6} -->

Of course we have to test this to see if this is correct.

Implement the following methods in the class `SquaredSeries`:

* `SeriesSum(int n)`: calculate the sum of the series of squares by adding the squares of the first `n` (inclusive) natural numbers. Start from `1`.
* `CalculateSumSeries(int n)`: find the sum of the series of squares by applying the above formula.

The `Main()` method already contains a small demo application. Feel free to change it to your liking.

## Expected Output

```text
Welcome to Series of Square

Let's determine the sum of the following series:
1^2 + 2^2 + 3^2 + 4^2 + 5^2

- Using summation: 55
- Using formula: 55

Super! The formula seems to be correct.
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
