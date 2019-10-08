# Child's Play

Create a new C# Console App (.NET Core). The goal of this app is to generate a certain number of additions that the user needs to solve as quickly as possible.

Follow the steps below to build the application from scratch.

1. Implement a for-loop that loops `3` times (we'll start with three additions). Generate two random numbers inside the for-loop with a maximum of `50`. Output the addition to the user in the form: `13 + 8 = ?`

Example Output:

```text
Welcome to child's play. Your source for math practice.
Try to answer the math problems as quickly as possible

13 + 8 = ?
39 + 5 = ?
22 + 8 = ?

Thanks for playing.
```

2. Next allow the user to answer the sums by reading the input from the console. Don't check the correctness just yet.

Example Output:

```text
Welcome to child's play. Your source for math practice.
Try to answer the math problems as quickly as possible

13 + 8 = ? 21
39 + 5 = ? 45
22 + 8 = ? 30

Thanks for playing.
```

3. Next check if the result of the user is correct or not. Output the result.

Example Output:

```text
Welcome to child's play. Your source for math practice.
Try to answer the math problems as quickly as possible

13 + 8 = ? 21
correct
39 + 5 = ? 45
incorrect
22 + 8 = ? 30
correct

Thanks for playing.
```

4. The idea is to not distract the user from his task by interrupting the solving process. In other words we are going to show the evaluation after the solving process. We do however need to track the correctness of the additions. This can be done by creating a `string` variable outside of the for loop. Inside the for-loop we add our findings to the `string` (use the concatenation operator `+` to add parts to the `string`). Once all additions are solved we output the results. Once working correct, remove the intermediate output.

Example Output:

```text
Welcome to child's play. Your source for math practice.
Try to answer the math problems as quickly as possible

13 + 8 = ? 21
39 + 5 = ? 45
22 + 8 = ? 30

Your results:
13 + 8 = 21 (correct)
39 + 5 = 45 (incorrect - correct answer was 44)
22 + 8 = 30 (correct)

Thanks for playing.
```

5. Next we are going to time the user. For this the class `Stopwatch` can be used. Output the result to the user.

```csharp
// Create a StopWatch
Stopwatch stopwatch = new Stopwatch();

// Starting the stopwatch
stopwatch.Start();

// Stopping the stopwatch
stopwatch.Stop();

// Getting the elapsed time
Console.WriteLine("Milliseconds: " + stopwatch.ElapsedMilliseconds);
```

Example Output:

```text
Welcome to child's play. Your source for math practice.
Try to answer the math problems as quickly as possible

13 + 8 = ? 21
39 + 5 = ? 45
22 + 8 = ? 30

Your results:
13 + 8 = 21 (correct)
39 + 5 = 45 (incorrect - correct answer was 44)
22 + 8 = 30 (correct)

It took you 9.617s to solve 3 additions.
Thanks for playing.
```

6. Next to make it more fair we should wait until the user is ready to start. This can be accomplished using the code snippet below. Place it after the introduction of the app.

```csharp
Console.WriteLine("Press enter when ready ...");
Console.ReadKey();
```

Example Output:

```text
Welcome to child's play. Your source for math practice.
Try to answer the math problems as quickly as possible
Press enter when ready ...

13 + 8 = ? 21
39 + 5 = ? 45
22 + 8 = ? 30

Your results:
13 + 8 = 21 (correct)
39 + 5 = 45 (incorrect - correct answer was 44)
22 + 8 = 30 (correct)

It took you 9.617s to solve 3 additions.
Thanks for playing.
```

7. If you placed the starting and stopping of the stopwatch outside of the for-loop you are actually not measuring the response time of the user but also including some code processing. Place the starting and stopping of the stopwatch as narrow as possible around the input of the user. Only measure the reaction of the user.

8. Extra - Ask the user for a difficulty level (1, 2 or 3). Change the upper limit of the random numbers as you see fit.