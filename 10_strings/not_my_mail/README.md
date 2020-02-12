# Not My Mail

This application allows you to check the correctness of an email address. This is based on a number of basic checks.

The `EmailValidator` class is able to check whether an email has a valid basic format. The method `IsValidEmail ()` should return `true` if the email address meets the following basic checks:

* The email address contains an at `@`
* The email address contains a dot `.` after the `@` with at least 1 letter in between
* The email address has at least 1 letter before the `@`
* At least 1 letter is present after the last dot.

Your tasks (also see `View => Task List` in Visual Studio):

* Implement the `IsValidEmail()` method in the `EmailValidator` class so that it checks the `email` string for a valid email address.

## Expected output

```text
Welcome to email validator ...
Please enter email to check. Leave empty to stop.: nico.dewitte@vives.be
This is a valid email address
Please enter email to check. Leave empty to stop.: nico.vives.be
This email address is NOT valid
Please enter email to check. Leave empty to stop.: nico@vives
This email address is NOT valid
Please enter email to check. Leave empty to stop.: nico
This email address is NOT valid
Please enter email to check. Leave empty to stop.: nicodewitte@vives.be
This is a valid email address
Please enter email to check. Leave empty to stop.:
Thanks for using our validation app.
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.

## Solution

The solution can be found as a second project in the Visual Studio Solution under the name `Solution`.
