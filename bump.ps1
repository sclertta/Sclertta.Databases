param (
	[string]$argument
)
[string[]] $projects = @(
    "AccessControl",
    "Accounts",
    "Applications",
    "Gan",
    "SessionStorage"
)

foreach ($project in $projects) {
    $startInfo = New-Object System.Diagnostics.ProcessStartInfo 

    $startInfo.FileName = "dotnet"
    $startInfo.Arguments = "bump-version $argument"

    $startInfo.RedirectStandardError = $true 
    $startInfo.CreateNoWindow = $true
    $startInfo.RedirectStandardOutput = $true 
    $startInfo.UseShellExecute = $false
    $startInfo.WorkingDirectory = ".\src\Iatec.LegacyDatabases.$project"

    $process = New-Object System.Diagnostics.Process 
    $process.StartInfo = $startInfo 
    $process.Start() | Out-Null 
    $process.WaitForExit() 
  
    $process.StandardOutput.ReadToEnd()
    $process.StandardError.ReadToEnd()
}
