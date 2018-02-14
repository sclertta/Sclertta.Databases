param(
	[string[]] $projects = @(
		"Accounts",
		"Applications",
		"Personnel",
		"Persons",
		"Rbac",
		"State",
		"Users",
	)
)

foreach ($project in $projects) {
  Remove-Item "src\Sclertta.Databases.$project\bin\*\Sclertta.Databases.$project.*.nupkg" -Force
  dotnet pack "src\Sclertta.Databases.$project" -c Release
}


foreach ($project in $projects) {
  nuget.exe push -Source nuget.org "src\Sclertta.Databases.$project\bin\Release\Sclertta.Databases.$project.*.nupkg"
}