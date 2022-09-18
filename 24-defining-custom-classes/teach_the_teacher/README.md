---
name: Teach the Teacher
description: Store personal details of teacher
details: ./23-defining-custom-classes/teach_the_teacher/README.md
difficulty: Medium
solution: false
unitTests: true
keywords: classes methods
solved: false
notes:
---

# Teach the Teacher

Create a new class called `Teacher` that follows the following UML class diagram:

```text
#################################
# Teacher
#################################
# - firstname: string
# - lastname: string
#################################
# + Teacher()
# + SetFirstname(firstname: string)
# + SetLastname(lastname: string)
# + Fullname(): string
# + Email(): string
# + ToString(): string
#################################
```

The `Teacher` class is a basic data class that holds some personal information about a teacher at VIVES.

The class should hold two attributes for both the firstname and the lastname of the teacher.

Supply the following methods for the class:

* `SetFirstname()`: this method allows the user of the class to change the firstname of the teacher.
* `SetLastname()`: this method allows the user of the class to change the firstname of the teacher.
* `Fullname()`: this methods concatenates both the firstname and lastname and returns the teachers full name.
* `Email()`: this method returns the email address of the teacher based on his/her first and last name in the format: `"firstname.lastname@vives.be"`. Make sure all letters are lower cased and no spaces are left in the email address.
* `ToString()`: override the `Object.ToString()` method and return the teacher's name and email in the format used by many email clients: `"Firstname Lastname <firstname.lastname@vives.be>"`

Feel free to create a small demo app that creates a `Teacher` object, changes his/her first name and last name and output the details to the terminal.

## Unit Tests

This project has accompanying unit tests. See [xUnit Tests](/README.md#xunit-tests) on how to run them.

Do note that the unit tests will not run without errors until you created the class and the required methods. You could always put some of the tests in comments. Just make sure to uncomment them once the task at hand is supposedly finished.
