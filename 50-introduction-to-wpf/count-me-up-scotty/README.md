---
name: Count Me Up Scotty
description: Create a WPF App for Count Me Up Scotty
details: ./30-wpf/count-me-up-scotty/README.md
difficulty: Medium
solution: false
unitTests: false
keywords: wpf classes
solved: false
draft: true
notes:
---

# Count Me Up Scotty

Start from the classroom demo code or from this repository: [https://github.com/vives-introduction-to-programming-2019/count-me-up-scotty](https://github.com/vives-introduction-to-programming-2019/count-me-up-scotty).

First move the classes `Player`, `Game` and `SumChallenge` to a `.NET Standard Class Library`. Make sure that the console application keeps working.

Next create a new `WPF App (.NET Framework)`.

First create the graphical user interface. No need to add any code or behavior in the first steps.

Make sure to be creative. Experiment and make this application your own.

## Step 1 - Login Window

Create a login window using the WPF that has the following components:

* A title
* A textbox for the user's name
* A login button to switch to the next window

## Step 2 - Play Window

Next create a play window that allows the user to play the game. It needs:

* a title
* a start button
* a nicely styled text block that shows the challenge
* a textbox that allows the user to input his/her anwser
* a button to solve the challenge

Possible extra's:

* a text block that displays the current time
* a progress bar that displays the challenge progress

## Step 3 - User Input

Use a `try-catch` to catch the exceptions that are thrown when the user inputs something other than a valid integral number.

More info on exceptions can be found in the chapter 30: [https://base-to-ace.netlify.com/30-handling-exceptions/](https://base-to-ace.netlify.com/30-handling-exceptions/).

## Extra - ScoreBoard

This is not a mandatory part but it can give you some extra grades.

Try to implement a scoreboard that tracks the scores from the players. You can for example save and load the scores from a file. Feel free to experiment.

## Unit Tests

This project has no working unit tests at this moment.

## Remark

This challenge is an early draft. Still work in progress.

## DEADLINE

The deadline for this challenge is: **Sunday the 19th of April (23:59)**

## WARNING

This challenge is a solo-challenge. While you can help someone by giving some pointers or explaining something, the repo's should not contain copy-pasted code from another student. This challenge is a big part of you grade for OOP1, so be sure to take this challenge serious.
