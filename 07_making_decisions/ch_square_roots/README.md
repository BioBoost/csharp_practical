# Square Roots

Create a new C# Console Application (.NET Core) and call it `SquareRoots`.

Next search the Internet on how to determine the square root of an integer in C#. There is a method of the class `Math` that can do this.

Now let the user enter an integral value and calculate the square roots of that given number. A positive integral value has two square roots, the positive square root and the negative. So the square roots of `9` are `3` and `-3`.

Make sure to put a check in place for negative values as these cannot be processed and will crash your application. However, the square root of the negative number is the square root of the same positive value but in its complex form. For example: the square roots of `-9` are `3i` and `-3i`.

Example output:

```text
Welcome to my Square Root application.

Enter an integral value to get the roots: 16

The square roots of 16 are 4 and -4

Thanks for using my app. Goodbye.
```

Or when entering a negative value:

```text
Welcome to my Square Root application.

Enter an integral value to get the roots: -16

The square roots of -16 are 4i and -4i

Thanks for using my app. Goodbye.
```
