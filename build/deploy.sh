Source=$1
ApiKey=$2


dotnet nuget push artifacts/*.nupkg -source $Source -k $ApiKey 