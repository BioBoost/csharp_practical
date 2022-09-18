---
name: Hangman Refactored
description: Refactor the hangman game to a library and create a GUI
details: ./30-wpf/hangman-refactored/README.md
difficulty: Medium
solution: false
unitTests: false
keywords: wpf classes refactor
solved: false
draft: true
notes:
---

# Hangman Refactored

The previous semester all of us together build a fun Hangman game. While a perfect exercise at that moment it lacks a lot of good practices. On top of that it is still a terminal game.

This challenge consist of refactoring the game to make more use of classes and OOP principles and building a nice WPF GUI for the game.

The demo code with some minor alterations is included in this repository. Study the code carefully before starting with this challenge. Make sure to commit your different steps.

This challenge also leaves a lot of room for improving the game and being creative. Show me what you got !

## Minimum Requirements

The minimum requirements for this challenge are the following:

* Document your extra's and efforts in this README.
* Git history: This game needs a decent number of commits. If the progress can not be seen in the history of git I may assume you just copy pasted some stuff from internet
* Sources of things you use from the internet
* Refactor the hangman code to classes such as `Player`, `Game`, `WordLoader`, ...
* A `.NET Standard Class Library` from the actual game classes.
* A WPF App (.NET Framework) that provides a nice interface for the user
  * Be creative here and try to make something nice of it
* Make sure to make this app user friendly
  * Make sure the user is informed of what is expected of him/her

As you start adding other functionality, the chances are that the terminal game will not work anymore. That is fine. You do not need to refactor this project. You can leave that one as is.

## For Extra Grades

If you find yourself needing an extra challenge for this than feel free to pick some topics from the list below. They will be rewarded.

* Implement a Scoreboard
  * If you added a scoreboard to "Count Me Up Scotty" and you did this the OOP-way, then this will be easy.
* Add a difficulty level to the game
* Add cheats or easter eggs
* Load a list of words from the Internet
* Add sounds to the game
* Add a timer that counts down for the time left to guess for a letter
* Fix the terminal game so it still works
* Add unit tests for your classes.
* ...

## DEADLINE

The deadline for this challenge is: **Friday the 5th of June (23:59)**

## WARNING

This challenge is a solo-challenge. While you can help someone by giving some pointers or explaining something, the repo's should not contain copy-pasted code from another student. This challenge is a big part of you grade for OOP1, so be sure to take this challenge serious.
