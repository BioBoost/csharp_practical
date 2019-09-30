# Programming Bugs

This little application shows a funny message of the day. Or is was suppose to do this.

The method `ShowMessage` in the file `ProgrammingBugs\MessageOfTheDay.s` need further implementation. The message and author are already there. But they are suppose to be concatenated in a bit of a special way. Don't change the original variables `message` and `author`. The author is prefixed with a tab-character to make it indented and also surrounded with double quotes.

Expected output:

```text
If debugging is the process of removing software bugs, then programming must be the process of putting them in.
        By "Edsger Dijkstra"
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
