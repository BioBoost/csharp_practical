# Baby Roulette

Roulette is a game where the players chooses a number between 1 and 36. Once the player has chosen his number, a ball is placed inside the roulette wheel and the wheel is spun. If it lands on your number you win.

Create a new C# Console Application (.NET Core) that emulates the same behavior.

Generate a random number between `1` and `10` and request a guess from the user. If you wish you can make your application more realistic by letting it wait for a few seconds. You can use the following code snippet for this:

```csharp
System.Threading.Thread.Sleep(5000);
```

If they match, congratulate the player on winning the game. If the numbers don't match, output another message.

You can add some of your own conclusions as for example: `You guessed too low`, `You missed by 2`, ...

Example Output:

```text
Welcome to Baby Roulette. A game with high stakes.

Please enter a guess between 1 and 10 (both include): 6

Spinning the wheel ... Please wait

Ooooh too bad. You missed it by 2. The ball landed on 4.

Better luck next time.
```
