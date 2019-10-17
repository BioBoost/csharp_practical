# Binary Nibble

This application should allow a user to enter a positive decimal value between `0` and `255` and convert it to a binary string. Implement the algorithm to achieve this in the method `DecimalToBinary()` in the class `NumberSystemConverter`;

Example:

```text
Welcome to the Binary Nibble.

Please enter a positive value[0, 255]: 123

The decimal value 123, is represented in binary as: 0111 1011
```

Make sure to place a space between the first and second nibble. Also make sure to add padding zeros in front so the string will always contain 8 bits (`1 0010` becomes `0001 0010`).

You do not need to take negative numbers into account.

## From decimal to binary

```text
decimal = 123
binary = ""

123 % 2 = 1
    => binary = "1"

123 / 2 = 61

61 % 2 = 1
    => binary = "11"

61 / 2 = 30

30 % 2 = 0
    => binary = "011"

30 / 2 = 15

15 % 2 = 1
    => binary = "1011"

15 / 2 = 7

7 % 2 = 1
    => binary = "1 1011"

7 / 2 = 3

3 % 2 = 1
    => binary = "11 1011"

3 / 2 = 1

1 % 2 = 1
    => binary = "111 1011"

1 / 2 = 0

DONE

Add padding: binary = "0111 1011"
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
