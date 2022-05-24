# Requirements
- Can convert 1 digits
- Can convert 2 digits
- Can convert 3 digits
- Can convert 4 digits
- Can support 4123.54
- Can support negative number


# Helpful command

## show test cases
dotnet test --logger "console;verbosity=detailed"

## test report
dotnet test  --logger "html;logfilename=testResults.html"

## create coverage report
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=OpenCover
reportgenerator -reports:./test/NumberToString.Test/coverage.opencover.xml -targetdir:./cover

