$packPath = (split-path -parent $MyInvocation.MyCommand.Definition) + '\'

$cmd = 'nuget pack ' + $packPath + 'Lib.csproj -Symbols'

$cmd

# & $cmd


