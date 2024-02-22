$name = $args[0]
if (!(Test-Path "./src/$name.sln")) {
  Write-Error "Solution $name not found!" -ErrorAction Stop
}

cd "./src"

for (($i = 1); $i -lt $args.length; $i++)
{
    $modulename = (Get-Culture).TextInfo.ToTitleCase($args[$i].ToLower())
    $modulepath = $args[$i].ToLower()
    $moduleservice = $modulename + "Service"
    abp new $modulename -t module --no-ui -o "modules/$modulepath" 
    abp add-module Volo.TenantManagement -s "modules/$modulepath/$modulename.sln" --skip-db-migrations
    dotnet remove "./modules/$modulepath/host/$modulename.HttpApi.Host/$modulename.HttpApi.Host.csproj" reference (Get-ChildItem -r **/*.csproj)
    Move-Item -Path "./modules/$modulepath/host/$modulename.HttpApi.Host" -Destination "./microservices/$moduleservice.Host" -Force
    mv "./microservices/$moduleservice.Host/$modulename.HttpApi.Host.csproj" "./microservices/$moduleservice.Host/$moduleservice.Host.csproj"
    Rename-Item -Path "./microservices/$moduleservice.Host/$($modulename)HttpApiHostModule.cs" -NewName "$($modulename)ServiceModule.cs"
    dotnet add "./microservices/$moduleservice.Host/$moduleservice.Host.csproj" reference "./modules/$modulepath/src/$modulename.Application/$modulename.Application.csproj"
    dotnet add "./microservices/$moduleservice.Host/$moduleservice.Host.csproj" reference "./modules/$modulepath/src/$modulename.EntityFrameworkCore/$modulename.EntityFrameworkCore.csproj"
    dotnet add "./microservices/$moduleservice.Host/$moduleservice.Host.csproj" reference "./modules/$modulepath/src/$modulename.HttpApi/$modulename.HttpApi.csproj"
}

Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB.Tests)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Host.Shared)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Installer)
Remove-Item -Recurse -Force (Get-ChildItem -r **/host)
Remove-Item -Recurse -Force (Get-ChildItem -r **/database)

dotnet sln "./$name.sln" add (Get-ChildItem -r **/*.csproj)

cd "../"
