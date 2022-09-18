# Point In Space

Create a new class called `Point` that follows the following UML class diagram:

```text
#################################
# Point
#################################
# - x: int
# - y: int
#################################
# + SetX(xValue: int): void
# + SetY(yValue: int): void
# + GetX(): int
# + GetY(): int
# + ToString(): string
#################################
```

Add two attributes to the class named `x` and `y`. These represent the coordinates of the `Point` in 2D-space.

Also add methods to change both values and also to retrieve both values.

Last, `override` the `ToString()` method so it returns the `Point` in the following format: `[13,12]` where the first coordinate is `x` and the second is `y`.

Feel free to create a small demo app that creates a `Point` object, changes it's coordinates and outputs it state to the terminal.

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.

Do note that you will be able to run the tests until you implemented the `Point` class. Or at least created the required methods.
