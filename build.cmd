::@echo off
cls 

".nuget\nuget.exe" "install" FAKE -OutputDirectory packages -ExcludeVersion
".nuget\nuget.exe" "install" "SourceLink.Fake" "-OutputDirectory" "packages" "-ExcludeVersion" "-version" "0.4.2"

:Build


SET TARGET="android-pack"

IF NOT [%1]==[] (set TARGET="%1")

SET BUILDMODE="Debug"

IF NOT [%2]==[] (set BUILDMODE="%2")

:: because we want to run specific steps inline on qed
:: we need to break the dependency chain
:: this ensures we do a build before running any tests

:: if %TARGET%=="Default" (SET RunBuild=1)
:: if %TARGET%=="RunUnitTests" (SET RunBuild=1)
:: if %TARGET%=="RunIntegrationTests" (SET RunBuild=1)
:: if %TARGET%=="CreatePackages" (SET RunBuild=1)

:: if NOT "%RunBuild%"=="" (
:: "packages\FAKE\tools\Fake.exe" "build.fsx" "target=android-pack" "buildMode=%BUILDMODE%"
:: )

"packages\FAKE\tools\Fake.exe" "build.fsx" "target=%TARGET%" "buildMode=%BUILDMODE%"

rem Bail if we're running a TeamCity build.
if defined TEAMCITY_PROJECT_NAME goto Quit

rem Bail if we're running a MyGet build.
if /i "%BuildRunner%"=="MyGet" goto Quit

:Quit
exit /b %errorlevel%