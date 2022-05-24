#!/bin/bash
rm -rf test
rm -rf source
rm NumberToString.sln
dotnet new sln -n NumberToString
dotnet new classlib -n NumberToString -o ./source/NumberToString
dotnet new xunit -n NumberToString.Test -o ./test/NumberToString.Test
dotnet sln add ./source/NumberToString/NumberToString.csproj
dotnet sln add ./test/NumberToString.Test/NumberToString.Test.csproj
dotnet add ./test/NumberToString.Test/NumberToString.Test.csproj reference ./source/NumberToString/NumberToString.csproj
dotnet add ./test/NumberToString.Test/NumberToString.Test.csproj package FluentAssertions
dotnet add ./test/NumberToString.Test/NumberToString.Test.csproj package coverlet.msbuild
dotnet add ./test/NumberToString.Test/NumberToString.Test.csproj package Moq
dotnet test /p:CollectCoverage=true
dotnet run --project ./source/NumberToString/NumberToString.csproj
