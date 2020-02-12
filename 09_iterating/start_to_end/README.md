# Start to End

This C# application can make the sum of a series of numbers. Two `Sum` methods are available:

* `Sum(int start, int end)` will make the sum of all the values between `start` (inclusive) and `end` (exclusive). Example: `Sum(1, 5)` will result in `1, 2, 3, 4` where the sum equals `10`.
* `Sum(int start, int step, int end)` will make the sum of all the values between `start` (inclusive) and `end` (exclusive) but the values will increment using the `step` value. Example: `Sum(1, 2, 8)` will result in `1, 3, 5, 7` where the sum equals `16`.

Implement both methods inside the `Series` class.

Can you explain what happens if:

* you take a start value that is bigger than the end value?
* you take a negative step value?
* you take a step value of `0`

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
