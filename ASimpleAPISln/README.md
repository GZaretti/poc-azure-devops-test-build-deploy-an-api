# Creating ASimpleAPISln and adding projects
```
dotnet new sln --name ASimpleAPISln
dotnet sln ASimpleAPISln.sln add src/ASimpleAPI/ASimpleAPI.csproj test/ASimpleAPI.Test/ASimpleAPI.Test.csproj
dotnet add test/ASimpleAPI.Test/ASimpleAPI.Test.csproj reference src/ASimpleAPI/ASimpleAPI.csproj
```