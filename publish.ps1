[string[]] $projects = @(
    "AccessControl",
    "Accounts",
    "Applications",
    "Gan",
    "SessionStorage"
)

foreach ($project in $projects) {
  Remove-Item "src\Iatec.LegacyDatabases.$project\bin\*\Iatec.LegacyDatabases.$project.*.nupkg" -Force
  dotnet pack "src\Iatec.LegacyDatabases.$project" -c Release
}


foreach ($project in $projects) {
  nuget.exe push -Source "EnterpriseLibrary" -ApiKey VSTS "src\Iatec.LegacyDatabases.$project\bin\Release\Iatec.LegacyDatabases.$project.*.nupkg"
}