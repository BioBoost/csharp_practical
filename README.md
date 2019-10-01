# CSharp Practical

This repository belongs to: **YOUR_NAME_HERE**

This repository contains the exercises and challenges that accompany the C\# course at VIVES University of Applied Sciences at Bruges which can be found at [http://base-to-ace.netlify.com](http://base-to-ace.netlify.com).

Each chapter may contain both a number of exercises as well as challenges. Exercises come with solutions, challenges do not.

All exercises and challenges contain at least a `README.md` describing the task at hand. Most already contain a Visual Studio solution to start from.

## Starting as a Student

To get started you will first need to get a copy of this repository. Follow the steps below to get your own personal copy. This only needs to be done once.

1. Get the GitHub classroom invitation link from Toledo
2. Accept the assignment
3. Wait for your own personal copy to be created (can take up to several minutes)
4. Open the GitHub page of your repository
5. Copy the ssh clone-url (green button) that looks like `git@github.com:vives-introduction-to-programming-2019/csharp_practical-<username>.git`
6. Traverse to a local directory on your system where you wish to clone the repo using Windows Explorer. Open PowerShell in that location by typing `powershell` in the location bar as shown in the screenshot below.

*Please don't choose a destination directory that is nested very deeply. The structure of this repo introduces quite a lot of subdirectories and might give problems towards maximum path length in Windows.*

![Opening PowerShell in directory](./img/powershell.png)

7. Issue the `git clone` command followed by the url you copied.

```shell
git clone <place-ssh-url-here>
```

You should get the following output:

```text
Cloning into 'csharp-practical-BioBoost'...
Warning: Permanently added the RSA host key for IP address '192.30.253.113' to the list of known hosts.
remote: Enumerating objects: 185, done.
remote: Compressing objects: 100% (109/109), done.
Receiving objects: 100% (185/185), 128.22 KiB | 625.00 KiB/s, done.
Resolving deltas: 100% (57/57), done.
```

Now you should have your local copy of the repository.

All git commands in other sections should always be executed inside of the project dir called `csharp-practical-<username>`.

## Committing Changes

Changes can be committed and pushed back to GitHub using the terminal.

Traverse to your local `csharp-practical-<username>` directory and type `powershell` in the location bar as done previously in [section Starting as a Student](#starting-as-a-student).

1. Add all changed files: `git add .`
2. Commit the files and add a message: `git commit -m "My message goes here"`
3. Push your changes to GitHub: `git push origin master`

![Committing and pushing via PowerShell](./img/commit_push_powershell.png)

4. To make sure all is well, you can always issue the command `git status`, even in between other commands.

You can also navigate to your GitHub page of this repo and check if all went well.

Make it a habit of committing regularly. At least after solving each assignment.

Also checkout the [shortened version of these steps for everyday use](./short_instructions.md).

## Pulling the Latest Updates

To pull the latest updates you will first need to add the original repo on which this one was based. This only needs to be done once for every cloned instance:

```shell
git remote add base git@github.com:vives-introduction-to-programming-2019/csharp_practical.git
```

`base` is the name of remote repo. Now you should see two remotes when issuing the command `git remote -v`. For example:

```text
base     git@github.com:vives-introduction-to-programming-2019/csharp_practical.git (fetch)
base     git@github.com:vives-introduction-to-programming-2019/csharp_practical.git (push)
origin  git@github.com:vives-introduction-to-programming-2019/csharp-practical-BioBoost.git (fetch)
origin  git@github.com:vives-introduction-to-programming-2019/csharp-practical-BioBoost.git (push)
```

Now every time you wish to pull updates you need to follow these steps:

1. First make sure that you have no local changes. This can be seen by executing `git status`. It should state `nothing to commit, working tree clean`. If not, you first need to add and commit the changes (see section [Committing Changes](#committing-changes)).
2. Now issue the command `git pull base master` to pull the latest changes.

![Pulling Changes](./img/pull_changes.png)

Also checkout the [shortened version of these steps for everyday use](./short_instructions.md).

## Overview

Please indicate which challenges you have finished by placing a ✔️ emoji in the finished column. These were found at [https://emojipedia.org](https://emojipedia.org).

## xUnit Tests

Unit Tests allow code to be tested automatically for correctness.

Some exercises/challenges might be accompanied by these tests (👍 in `Unit Tests?` column).

Open the `Test Explorer` overview in Visual Studio by navigating to `Test => Windows => Test Explorer`.

Hit the first green arrow at the top left (Run All):

![Run All Tests](./img/run_all_unit_tests.png)

Normally the tests will always fail in the beginning.

![Failing Tests](./img/failing_tests.png)

If the challenge/exercise is solved correctly, all tests should pass.

![Succeeding Tests](./img/succeeding_tests.png)

### Introduction to Programming

#### Chapter 01 - Introduction to Computer Programming

##### Challenges

| Finished | Challenge | Difficulty | Description |
| :---: | --- | --- | --- |
| ❌ | [Making a Sandwich](./01_introduction/ch_making_a_sandwich/README.md) | Easy | Document the process of making a ham and cheese sandwich. |
| ❌ | [Programming Languages](./01_introduction/ch_programming_languages/README.md) | Medium | Search the Internet for some programming languages. |
| ❌ | [Processor Architecture](./01_introduction/ch_processor_architecture/README.md) | Medium | Search the Internet for the meaning of a processor architecture. |
| ❌ | [Biggest Number in a List](./01_introduction/ch_biggest_number_in_a_list/README.md) | Hard | Document the process of finding the biggest number in a list. |

#### Chapter 02 - Basic Building Blocks

##### Exercises

| Exercise | Difficulty | Description |
| --- | --- | --- |
| [BMI Adult Check](./02_building_blocks/ex_bmi_adult_check/README.md) | Easy | Check if user is an adult when calculating the BMI |
| [Circle Circumference](./02_building_blocks/ex_circle_circumference/README.md) | Medium | Determine the circumference of a circle |
| [Cinema](./02_building_blocks/ex_cinema/README.md) | Easy | Determine the properties of a cinema screening |

##### Challenges

| Finished | Challenge | Difficulty | Description |
| :---: | --- | --- | --- |
| ❌ | [Personalized BMI](./02_building_blocks/ch_personalized_bmi/README.md) | Easy | Personalize the BMI example with the users name |
| ❌ | [Rectangle Area](./02_building_blocks/ch_rectangle_area/README.md) | Medium | Determine the area of a rectangle |
| ❌ | [Smartphones](./02_building_blocks/ch_smartphones/README.md) | Easy | Determine the properties of Smartphones |
| ❌ | [Motorcycles](./02_building_blocks/ch_motorcycles/README.md) | Medium | Determine the properties of Motorcycles |
| ❌ | [Student Grader](./02_building_blocks/ch_student_grader/README.md) | Medium | Output message to user based on his grade |
| ❌ | [Sum of Numbers](./02_building_blocks/ch_sum_of_numbers/README.md) | Hard | Determine the sum of a list of numbers |

#### Chapter 03 - Starting in C#

##### Exercises

| Exercise | Difficulty | Description |
| --- | --- | --- |
| [Need a Break](./03_starting_csharp/ex_need_a_break/README.md) | Medium | Find and fix two small syntax errors |

##### Challenges

| Finished | Challenge | Difficulty | Description |
| :---: | --- | --- | --- |
| ❌ | [Hello World](./03_starting_csharp/ch_hello_world/README.md) | Easy | Print a Hello World message |
| ❌ | [Basic Syntax Error](./03_starting_csharp/ch_basic_syntax_error/README.md) | Easy | Find and fix a small syntax error |
| ❌ | [Developed By](./03_starting_csharp/ch_developed_by/README.md) | Easy | Print message and your name |
| ❌ | [Java Programmer](./03_starting_csharp/ch_java_programmer/README.md) | Easy | Fix mistake of a Java programmer |
| ❌ | [My First App](./03_starting_csharp/ch_my_first_app/README.md) | Medium | Create a new VS Project |
| ❌ | [Personal Details](./03_starting_csharp/ch_personal_details/README.md) | Medium | Print out personal details |

#### Chapter 04 - Storing Data

##### Exercises

| Finished | Challenge | Difficulty | Description | Unit Tests? |
| :---: | --- | --- | --- | :---: |
| ❌ | [C# Land](./04_storing_data/ex_csharp_land/README.md) | Easy | Initialize minimum required height variable | 👍 |
| ❌ | [Frame Delimiter](./04_storing_data/ex_frame_delimiter/README.md) | Medium | Initialize start and end of frame delimiter | 👍 |
| ❌ | [Marco Polo](./04_storing_data/ex_marco_polo/README.md) | Medium | Output some personal details about Marco Polo | 👍 |
| ❌ | [Programming Bugs](./04_storing_data/ex_programming_bugs/README.md) | Hard | Output authored message of the day | 👍 |

#### Chapter 05 - Processing Data

##### Exercises

| Finished | Challenge | Difficulty | Description | Unit Tests? |
| :---: | --- | --- | --- | :---: |
| ❌ | [Rectangle Properties](./05_processing_data/ex_rectangle_properties/README.md) | Easy | Calculate area and circumference of a rectangle | 👍 |
| ❌ | [Pizza Time](./05_processing_data/ex_pizza_time/README.md) | Medium | Divide pizzas among people | 👍 |
| ❌ | [Evaluation](./05_processing_data/ex_evaluation/README.md) | Medium | Determine final score of course | 👍 |
| ❌ | [Calculating VAT](./05_processing_data/ex_calculate_vat/README.md) | Medium | Calculate taxes on a netto value | 👍 |

##### Challenges

| Finished | Challenge | Difficulty | Description |
| :---: | --- | --- | --- |
| ❌ | [Circle Properties](./05_processing_data/ch_circle_properties/README.md) | Hard | Show properties of a circle |

#### Chapter 06 - Getting User Data

##### Exercises

| Finished | Challenge | Difficulty | Description | Unit Tests? |
| :---: | --- | --- | --- | :---: |
| ❌ | [Student ID](./06_getting_user_data/ex_student_id/README.md) | Medium | Generate student email and ID | 👍 |
| ❌ | [Time Machine](./06_getting_user_data/ex_time_machine/README.md) | Hard | Add hours and minutes to clock | 👍 |

#### Chapter 07 - Making Decisions

##### Challenges

| Finished | Challenge | Difficulty | Description |
| :---: | --- | --- | --- |
| ❌ | [Square Roots](./07_making_decisions/ch_square_roots/README.md) | Medium | Determine square roots of integer numbers |
