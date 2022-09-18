# Frame Delimiter

Frame delimiters are often used in communication protocols. They denote the start and end of a piece of data that is being transmitted.

This application models the beginning of such a data frame.

A frame

* starts with the value `0xAA`
* ends with the value `0x55`

Initialize the variables `startOfFrame` and `endOfFrame` so they both have the correct value.

Change the code in the method `StartOfFrame` and `EndOfFrame` in the file `FrameDelimiter\Frame.cs`.

Don't worry that both values print as decimals. Expected output:

```text
A frame always starts with: 170
A frame always ends with: 85
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
