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
$PROJECT="SumOfNumbers"

dotnet new console --name $PROJECT --language c# --framework netcoreapp2.1
dotnet new xunit --name Tests --language c# --framework netcoreapp2.1
dotnet new sln --name $PROJECT
dotnet sln $PROJECT.sln add $PROJECT/$PROJECT.csproj Tests/Tests.csproj
```
