# LED Series Resistor

An LED (Light Emiting Diode) is an electronic component that emits light if current flows through it. LEDs show a voltage drop, depending on the type and color. It is required to provide a resistor for each LED.

Before the resistance can be calculated, the following data is required:

1. The voltage over the LED
2. The required current for the LED
3. The supply voltage that will be used

Then the series resistor can be calculated using the formula:

![Formula](./img/formula.png)

Your task (also see `View => Task List` in Visual Studio):

* Implement the method `CalculateSeriesResistor()` in the class `ResistorCalculator` so it determines the resistance.

## Expected output

```text
Welcome to the LED series resistor calculator
Your place to calculate your series resistors for LEDs.
----------------------------------------------------

Please enter your supply voltage [V]: 9
Please enter the voltage drop over the LED [V]: 2
What current do you want to drive through the LED [A]: 0.01

You will need a resistor of 700 Ohm
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
