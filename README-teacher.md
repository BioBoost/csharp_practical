# Readme for Teacher

## TODOs

* Create Alias for creating C# apps via CLI
* Create Alias for updating projects to a certain .net version
* Remove the challenge/exercise difference

### Arrays

* Reverse of an array
* Find index of first numbers
* Find all indices (actually return array of indices)
* Array of 10 random numbers
* Print array of strings
* Initialize array with some specific numbers
* Sort array of ints
* Split string into array of words => maybe even some sort of small command parser? Class demo?

## Creating C# Apps via CLI

```shell
PROJECT="BiggestOfThemAll"

mkdir $PROJECT ; cd $PROJECT
dotnet new console --name $PROJECT --language c# --framework net6.0 --use-program-main
dotnet new xunit --name Tests --language c# --framework net6.0
dotnet new sln --name $PROJECT
dotnet sln $PROJECT.sln add $PROJECT/$PROJECT.csproj Tests/Tests.csproj
dotnet add Tests/Tests.csproj reference $PROJECT/$PROJECT.csproj
touch README.md
```

or when using GitHub actions and automatic test runs:

```powershell
PROJECT="BiggestOfThemAll"

mkdir $PROJECT ; cd $PROJECT
dotnet new console --name $PROJECT --language c# --framework net6.0 --use-program-main
dotnet new xunit --name Tests --language c# --framework net6.0
dotnet new sln --name $PROJECT
dotnet sln $PROJECT.sln add $PROJECT/$PROJECT.csproj Tests/Tests.csproj
dotnet add Tests/Tests.csproj reference $PROJECT/$PROJECT.csproj
dotnet add Tests/Tests.csproj package LiquidTestReports.Markdown
touch README.md
```

## Updating .NET Framework

Using the power of Linux of course:

```bash
find . -name "*.csproj" -exec sed -i 's/netcoreapp3.1/net6.0/' '{}' \;
```

Or using PowerShell:

```powershell
Get-ChildItem -Path .\ -Filter *.csproj -Recurse -File -Name| ForEach-Object {
  (Get-Content $_).replace('netcoreapp3.1', 'net6.0') | Set-Content $_
}
```
