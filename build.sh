#!/bin/bash

set Configuration=Release
set OutputDir=artifacts/

dotnet build -c $Configuration src/Sclertta.Databases.sln
dotnet pack -c $Configuration src/Sclertta.Databases.sln

mkdir -p $OutputDir

cp src/Sclertta.Databases.Accounts/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Applications/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Personnel/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Persons/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Rbac/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.State/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Users/bin/$Configuration/*.nupkg $OutputDir
