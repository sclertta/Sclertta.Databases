#!/bin/bash

Configuration=Release
OutputDir=artifacts/

rm -rf src/Sclertta.Databases.Accounts/bin
rm -rf src/Sclertta.Databases.Applications/bin
rm -rf src/Sclertta.Databases.Personnel/bin
rm -rf src/Sclertta.Databases.Persons/bin
rm -rf src/Sclertta.Databases.Rbac/bin
rm -rf src/Sclertta.Databases.State/bin
rm -rf src/Sclertta.Databases.Users/bin


dotnet build -c $Configuration src/Sclertta.Databases.sln
dotnet pack  -c $Configuration src/Sclertta.Databases.sln

rm -rf $OutputDir
mkdir -p $OutputDir

cp src/Sclertta.Databases.Accounts/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Applications/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Personnel/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Persons/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Rbac/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.State/bin/$Configuration/*.nupkg $OutputDir
cp src/Sclertta.Databases.Users/bin/$Configuration/*.nupkg $OutputDir
