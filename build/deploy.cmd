@echo off

set SCRIPT_DIR=%~dp0
set ARTIFACTS_DIR=%SCRIPT_DIR%..\artifacts\

set Source=%1
set ApiKey=%2

dotnet nuget push %ARTIFACTS_DIR%*.nupkg --source %Source% --api-key %ApiKey%
