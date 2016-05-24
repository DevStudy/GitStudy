$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'

$version = [System.Reflection.Assembly]::LoadFile("$root\sources\Demo\Lib\bin\Release\Lib.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\nuget\Lib.nuspec)
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\nuget\Lib.compiled.nuspec

& $root\nuget\NuGet.exe pack $root\nuget\Lib.compiled.nuspec

