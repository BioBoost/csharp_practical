# Rectangle Area

The rectangle app allows you to calculate the area of a rectangle based on its `width` and `height`. Change the `Main` method to request both these floating-point values from the user.

Next implement the `CalculateArea()` method inside of the class `Rectangle` to determine the area of the rectangle. However you should add a precaution to the code if either of the values is smaller than `0`. In that case return an `area` of `0`.

Also adopt this strategy inside of `Main` at the bottom when the result is shown to the user. If either value was negative, output an appropriate message to the user.

Example output with correct values:

```text
Welcome to the rectangle calculator

Please enter width of rectangle: 3.2
Please enter height of rectangle: 5.0

The area of a rectangle (3.2 by 5) = 16
```

Example output with negative values:

```text
Welcome to the rectangle calculator

Please enter width of rectangle: -4.3
Please enter height of rectangle: 5

Sorry, you provided negative value(s). Cannot determine area.
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
