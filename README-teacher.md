# Readme for Teacher

## TODOs

* Create Alias for creating C# apps via CLI
* Create Alias for updating projects to a certain .net version
* Remove the challenge/exercise difference

## Creating C# Apps via CLI

```shell
$PROJECT="SumOfNumbers"

dotnet new console --name $PROJECT --language c# --framework netcoreapp2.1
dotnet new xunit --name Tests --language c# --framework netcoreapp2.1
dotnet new sln --name $PROJECT
dotnet sln $PROJECT.sln add $PROJECT/$PROJECT.csproj Tests/Tests.csproj
```
