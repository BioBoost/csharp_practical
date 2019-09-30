# Evaluation

The evaluation app is a tool that calculates the average score and total score of a student for the course "Introduction to Programming". The total score is however not equal to the average but takes the following distribution into account:

* The exam counts for `40%` of the total score
* The lab counts for `60%` of the total score

Both the average and total score should return a value based on a score of `/20`. You can find the methods inside of the file `Evaluation\Grader.cs`.

Example:

```text
Lenny Dermond:
    Exam Score: 13.5/20
    LAB Score: 16.2/20
    Average Score: 14.85
    Total Score: 15.12
```

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.
