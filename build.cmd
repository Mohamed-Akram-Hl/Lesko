@echo off

dotnet build .\src\Lesko.sln /nologo
dotnet test .\src\Lesko.Tests\Lesko.Tests.csproj