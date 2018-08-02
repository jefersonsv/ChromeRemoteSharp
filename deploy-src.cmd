SET app=ChromeRemoteSharp
rd /s /q .\src\%app%\bin\Release
dotnet build -c Release .\%app%.sln
nuget push .\src\%app%\bin\Release\*.nupkg -Source https://api.nuget.org/v3/index.json