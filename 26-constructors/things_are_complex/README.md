---
name: Things are Complex
description: Math with Complex numbers
details: ./23-defining-custom-classes/things_are_complex/README.md
difficulty: Hard
solution: true
unitTests: true
keywords: classes methods operators
solved: false
notes:
---

# Things are Complex

Create a new class called `ComplexNumber` that follows the following UML class diagram:

```text
#################################
# ComplexNumber
#################################
# - real: double
# - imaginary: double
#################################
# + ComplexNumber()
# + ComplexNumber(real: double, imaginary: double)
# + Real(): double
# + Imaginary(): double
# + Magnitude(): double
# + Add(value: ComplexNumber): ComplexNumber
# + Subtract(value: ComplexNumber): ComplexNumber
# + Multiply(value: ComplexNumber): ComplexNumber
# + Divide(value: ComplexNumber): ComplexNumber
# + ToString(): string
#################################
```

The `ComplexNumber` class is an advanced class that allows a user to do calculus with complex numbers. For more information about complex numbers please read [https://en.wikipedia.org/wiki/Complex_number](https://en.wikipedia.org/wiki/Complex_number).

The class should hold the `real` and `imaginary` parts of the complex number.

Supply the following methods for the class:

* `ComplexNumber()`: The default constructor for a complex number that initialized both the real and imaginary part to `0`.
* `ComplexNumber(real: double, imaginary: double)`: An initialization constructor that allows the user to create a complex number with the given real and imaginary values.
* `Real(): double`: Returns the real part of the complex number
* `Imaginary(): double`: Returns the imaginary part of the complex number
* `Magnitude(): double`: Return the magnitude/modulus of the complex value
* `Add(value: ComplexNumber): ComplexNumber`: Add the two complex values together and return the result
* `Subtract(value: ComplexNumber): ComplexNumber`: Subtract value from the current complex number and return the result
* `Multiply(value: ComplexNumber): ComplexNumber`: Multiply value with the current complex number and return the result
* `Divide(value: ComplexNumber): ComplexNumber`: Divide the current complex number with value and return the result
* `ToString(): string`: Return a string representation of the complex number in the format `"(a + bi)"`. Make sure to override the `Object.ToString()` method

An important note to keep in mind is that the methods `Add()`, `Subtract()`, `Multiply()` and`Divide()` should not alter the internal state of either the own object or the argument object. It should return the result in a new `ComplexNumber` object.

Feel free to create a small demo app that demonstrates the usage of the ComplexNumber class.

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.

Do note that the unit tests will not run without errors until you created the class and the required methods. You could always put some of the tests in comments. Just make sure to uncomment them once the task at hand is supposedly finished.

## Solution

The solution can be found as a second project in the Visual Studio Solution under the name `Solution`.
