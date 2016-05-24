$root = (split-path -parent $MyInvocation.MyCommand.Definition) -replace '\\nuget','\'
$nugetPath = $root + 'nuget\'
$libPath = $root + '\sources\Demo\Lib\Lib.csproj'

#---------------debug------------------------#
#$root
#$nugetPath
#$libPath
#--------------------------------------------#

## build the nuget package
#nuget pack  $libPath -Symbols | out-file log.txt  ## 把编译日志输出到文本中去
#nuget pack  $libPath -Symbols

nuget pack  $libPath	## 生成正式的nuget包

nuget setApiKey {nuget_token}
nuget push *.nupkg -source https://www.nuget.org	#将所有生成的包发布至nuget.com上


