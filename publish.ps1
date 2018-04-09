[string[]] $projects = @(
    "AccessControl",
    "Accounts",
    "Applications",
	"Aps",
    "Gan",
    "SessionStorage"
)

foreach ($project in $projects) {
  Remove-Item "src\Iatec.Databases.$project\bin\*\Iatec.Databases.$project.*.nupkg" -Force
  dotnet pack "src\Iatec.Databases.$project" -c Release
}


foreach ($project in $projects) {
  nuget.exe push -Source "EnterpriseLibrary" -ApiKey VSTS "src\Iatec.Databases.$project\bin\Release\Iatec.Databases.$project.*.nupkg"
}