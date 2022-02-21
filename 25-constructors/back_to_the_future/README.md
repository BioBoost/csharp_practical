# Back to the Future

Often as a programmer one needs to work with dates and time stamps. To learn the problematics these classes solve, one first need to understand the inner workings. For this reason this challenge focusses on the creation of a versatile `TimeStamp` class that allows us to manipulate time.

Implement the following functionality in a class called `TimeStamp`:

* Properties for `Seconds`, `Minutes` and `Hours`.
  * When a negative value is supplied, make sure to reset the property in question to `0`.
  * When an overflow occurs, the timestamp should be normalized. For example supplying `105` seconds should result in `1` minute being added and the seconds should be set to `45`.
  * `Hours` should have a time format of `24 hours`.

* Constructors:
  * Supply a default constructor that takes no arguments. Set all properties to `0` in this case.
  * Supply a constructor that takes all three values (`Hours`, `Minutes` and `Seconds`). Make sure the resulting timestamp is again normalized.

* A `ToString()` method that returns the timestamp in the format `14h 13m 12s`.

* Three methods `AddSeconds`, `AddMinutes` and `AddHours` for adding `Seconds`, `Minutes` and `Hours`.
  * When the supplied value is negative, no action should be taken.
  * The resulting timestamp should again be normalized and not contain any overflowing values.

Implement a small demo application in the `Main` that outputs the expected output by calling the appropriate methods and setting the properties.

<!-- TODO: Subtract -->
<!-- TODO: Add timestamps together -->

## Expected Output

```text
Welcome to Back to the Future.
Here we are demonstrating a TimeStamp class.

Default construction: 0h 0m 0s
With timing info: 13h 12m 11s

Let's set the hours 12h ahead: 12h 0m 0s or for the second 1h 12m 11s
Let's set the minutes 66m ahead: 13h 6m 0s or for the second 2h 18m 11s
Let's set the seconds 138s ahead: 13h 8m 18s or for the second 2h 20m 29s

Very nice.
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.

Do note that the unit tests will not run without errors until you created the required classes/properties/methods. You could always run specific tests in the "Test Explorer" that target the functionality you are currently working on. Just don't forget to run all tests once you think you are finished.

Also make sure to make your classes `public`. Otherwise the unit tests will not be able to access them.
