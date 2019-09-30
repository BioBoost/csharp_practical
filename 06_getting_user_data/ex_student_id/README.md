# Student ID

The Student ID app is used by the administrative service of VIVES to generate email addresses and IDs for new students. However the generation of both the components has not been finished yet.

Fix the method `Email()` so it returns an email address in the format `firstname.lastname@student.vives.be`. Make sure that all letters are lower case. You can search the Internet on how to lowercase a full string.

Next an ID needs to be generated. For this you can use the `Random` class. Generate an ID number of `6` digits and prefix it with an `r`. Place the implementation inside of the `ID()` method.

Expected Output:

```text
Student information:
Firstname: Marco
Lastname: Polo
Email: marco.polo@student.vives.be
ID: r123056
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
