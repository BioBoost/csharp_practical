# Round About

Create a new class called `Circle` that follows the following UML class diagram:

```text
#################################
# Point
#################################
# - radius: double
#################################
# + SetRadius(radValue: double): void
# + GetRadius(): double
# + GetDiameter(): double
# + CalculateArea(): double
# + CalculateCircumference(): double
#################################
```

Add an attribute `radius` of type `double` to the `Circle`, which can be changed using the `SetRadius()` method. Make sure that the `radius` cannot be set to a negative value. In that case, don't change the actual `radius` but leave the current value.

Add methods to get the radius and the diameter of the circle.

Implement both the `CalculateArea()` and `CalculateCircumference()` methods, which calculate the area and circumference based on the current `radius` of the circle.

Feel free to create a small demo app that creates a `Circle` object, changes it's `radius` and outputs it state to the terminal.

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.

Do note that you will be able to run the tests until you implemented the `Circle` class. Or at least created the required methods.
