# Number Manipulator

Number Manipulator is a small app that allows us to manipulate numbers on a digit level.

The app provides the following methods in the class `Manipulator`:

* `Reverse(int value)`: reverses numbers, eg converting `12345` to `54321`. You simply reverse the number. When a number ends in `0`(s), you may ignore them for the result.
* `Complement(int value)`: calculate he complement of numbers, eg convert `12345` to `87654`. The value is per digit subtracted from `9`.
* `DigitSum(int value)`: determine the sum of the individual digits. The digit sum of `12345` is `15.

All methodes can be realized by approaching the number digit by digit. In other words, by working with division by `10` and module `10`.

The `Main()` method already contains a small demo application. Feel free to change it to your liking.

## Expected Output

```text
Welcome to Number Manipulator

Let's reverse some numbers:
 The inverted value of 123 is 321
 The inverted value of 9200 is 29
 The inverted value of 111 is 111
 The inverted value of 0 is 0

Let's complement some numbers:
 The complement value of 123 is 876
 The complement value of 9200 is 799
 The complement value of 111 is 888
 The complement value of 8 is 1
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
