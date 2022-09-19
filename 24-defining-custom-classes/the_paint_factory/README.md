# The Paint Factory

The Paint Factory is a company in Bruges that sells paint and is known for its excellent customer service. The next step in their customer experience is a new app to help people in calculating how much liters of paint they need for a paint job.

The app should allow to add both square and rectangular surfaces to the total area to be painted. The customer can then request the application to calculate how much paint is required.

To provide this functionality, the following methods should be implemented:

* `AddSquare(double side)`, a method that calculate the surface area of a square with a given side. It should add the result to the `totalArea` attribute.
* `AddRectangle(double width, double height)`, this methode calculates the area of a rectangular surface and adds the result to the `totalArea` to be painted.

Once the user has provided all the different surfaces, he/she can request how many liters of paint are required to paint the surface with a given number of coats. This is calculated in the methode `LitersOfPaint(int coats)`. To determine the resulting liters of paint, you will have to calculate the following:

1. First determine how many liters of paint are required to paint the total area with a single coat. You can assume here that 12 square meters can be painted with a single liter.
2. Next take the number of `coats` into account.
3. As a rule of thumb the customer is always recommended to take `5%` extra into account to make sure. Add `5%` extra paint to the current number of liters.
4. To get the final result, you will need to round the result upwards to an integral value. This can be achieved with the method `Math.Ceiling()`.

The `Main()` method already contains a small demo application. Feel free to change it to your liking.

## Expected Output

```text
Welcome to Paint Calculator.

We are painting the following area:
 - A square area of 4m by 4m
 - A rectangle area of 2m by 6m
 - A rectangle area of 10m by 2m
This results in a total area of 48 square meters.

Let us put 2 coats of paint on the walls.
For this we will need 9 liters of paint.
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
