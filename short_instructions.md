# CSharp Practical

All exercises and challenges contain at least a `README.md` describing the task at hand. Most already contain a Visual Studio solution to start from.

## Committing Changes

Changes can be committed and pushed back to GitHub using the terminal.

Traverse to your local `csharp-practical-<username>` directory and open a PowerShell window by holding down <kbd>Shift</kbd> and right clicking the directory. Next select `Open PowerShell window here` from the context menu, as done previously in [section Starting as a Student](#starting-as-a-student).

1. Add all changed files using the command: `git add .`
2. Commit the files and add a message: `git commit -m "My message goes here"`
3. Push your changes to GitHub: `git push origin master`
4. To make sure all is well, you can always issue the command `git status`, even in between other commands.

You can also navigate to your GitHub page of this repo and check if all went well.

Make it a habit of committing and pushing regularly. **At least after solving each assignment.**

## Pulling the Latest Updates

Every time you wish to pull updates you need to follow these steps:

1. First make sure that you have no local changes. This can be seen by executing `git status`. It should state `nothing to commit, working tree clean`. If not, you first need to add and commit the changes (see section [Committing Changes](#committing-changes)).
2. Now issue the command `git pull base master --allow-unrelated-histories` to pull the latest changes.
