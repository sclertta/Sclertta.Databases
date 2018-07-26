@echo off

REM Set variables
set Configuration=Release
set OutputDir=artifacts\

REM Remove bin/ folders
rmdir /s/q src\Sclertta.Databases.Accounts\bin
rmdir /s/q src\Sclertta.Databases.Applications\bin
rmdir /s/q src\Sclertta.Databases.Personnel\bin
rmdir /s/q src\Sclertta.Databases.Persons\bin
rmdir /s/q src\Sclertta.Databases.Rbac\bin
rmdir /s/q src\Sclertta.Databases.State\bin
rmdir /s/q src\Sclertta.Databases.Users\bin

dotnet pack -c %Configuration% src\Sclertta.Databases.sln

REM Delete OutputDir
if exist %OutputDir% rmdir /s/q %OutputDir%
mkdir %OutputDir%

REM Copy nuget packages to OutputDir
copy src\Sclertta.Databases.Accounts\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Applications\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Personnel\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Persons\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Rbac\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.State\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Users\bin\%Configuration%\*.nupkg %OutputDir%
