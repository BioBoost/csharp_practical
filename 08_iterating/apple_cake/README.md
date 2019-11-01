# AppleCake

AppleCake is a kind of word-game for children. The purpose is to iterate the list of natural numbers, incrementing the number each round. If the number is dividable by `3`, you shout `apple`, or `cake` if it is dividable by `5`. In case the number is dividable by both `3` and `5`, you shout `applecake`.

This application generates an overview of the natural numbers and their labels. However some functionality still needs to be implemented.

Your task (also see `View => Task List` in Visual Studio):

* Implement the method `AppleCake()` in the class `AppleCakeGenerator` so it returns the correct string for a given `value`, namely `apple`, `cake` or `applecake`.
* Implement the method `Generate()` in the class `AppleCakeGenerator` so it iterates all the numbers from `start` to `end` (inclusive). Call the method `string text = AppleCake(i)` on each iteration and add the result to the `output` string.

## Expected output

```text
Welcome to the AppleCake generator
3: apple
5: cake
6: apple
9: apple
10: cake
12: apple
15: applecake
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
