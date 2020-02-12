# Time for Change

A vending machine allows the user to input money and select a product to buy. Once the cost of the product is determined, the vending machine will return change if the user inputted to much money.

Write a small .NET Core application that demonstrates this. Determine how much coins need to be returned.

Start with a fixed product price and then extend the application to allow the user to select a product from a list.

You may assume that the vending machine returns coins of (1cent, 2cent, 5cent, 10cent, 20cent, 50cent, 1euro and 2euro).

## Example Output

```text
Vending Machine Simulator.

Please select a product:

1. Cola [2.2eur]
2. Fanta [2.2eur]
3. Water [1eur]
4. Red Bull [2.70eur]

Choice: 4

Please insert at least 2.70eur.

Insert: 3

You inserted 3eur.

Your change: 1x 20cent + 1x 10cent

Thank you and enjoy your Red Bull
```