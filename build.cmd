set Configuration=Release
set OutputDir=artifacts\

rmdir /s/q src\Sclertta.Databases.Accounts\bin
rmdir /s/q src\Sclertta.Databases.Applications\bin
rmdir /s/q src\Sclertta.Databases.Personnel\bin
rmdir /s/q src\Sclertta.Databases.Persons\bin
rmdir /s/q src\Sclertta.Databases.Rbac\bin
rmdir /s/q src\Sclertta.Databases.State\bin
rmdir /s/q src\Sclertta.Databases.Users\bin

dotnet build -c %Configuration% src\Sclertta.Databases.sln
dotnet pack  -c %Configuration% src\Sclertta.Databases.sln

if exist %OutputDir% rmdir /s/q %OutputDir%

copy src\Sclertta.Databases.Accounts\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Applications\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Personnel\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Persons\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Rbac\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.State\bin\%Configuration%\*.nupkg %OutputDir%
copy src\Sclertta.Databases.Users\bin\%Configuration%\*.nupkg %OutputDir%
