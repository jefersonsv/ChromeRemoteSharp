rem remove releases
rd /s /q .\src\ChromeRemoteSharp\bin\Release

rem build release
dotnet build -c Release .\ChromeRemoteSharp.sln

rem pack nuget
nuget pack ChromeRemoteSharp.nuspec

rem push nuget
nuget push .\*.nupkg -Source https://api.nuget.org/v3/index.json

rem remove pack
del /f /s /q .\*.nupkg