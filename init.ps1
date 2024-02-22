$name = $args[0]
mkdir "./src"
cd "./src"

dotnet new sln -n "$name"

mkdir "./applications"
mkdir "./microservices" 

dotnet new web -n "AdminGateway.Host" -o "gateways/AdminGateway.Host"
dotnet add "gateways/AdminGateway.Host/AdminGateway.Host.csproj" package Ocelot
dotnet new web -n "InternalGateway.Host" -o "gateways/InternalGateway.Host"
dotnet add "gateways/InternalGateway.Host/InternalGateway.Host.csproj" package Ocelot
dotnet new web -n "PublicGateway.Host" -o "gateways/PublicGateway.Host"
dotnet add "gateways/PublicGateway.Host/PublicGateway.Host.csproj" package Ocelot

dotnet new classlib -n "$name.Shared" -o "shared/$name.Shared"
dotnet new classlib -n "$name.EventBus" -o "shared/$name.EventBus"
dotnet new classlib -n "$name.Permisson" -o "shared/$name.Permisson"
dotnet new classlib -n "$name.Security" -o "shared/$name.Security"

abp new "Identity" -t module --no-ui -o "modules/identity"
abp add-module Volo.Identity -s "modules/identity/Identity.sln" --skip-db-migrations
abp add-module Volo.IdentityServer -s "modules/identity/Identity.sln" --skip-db-migrations
Copy-Item -Path "./modules/identity/common.props" -Destination "./common.props" -Recurse
dotnet remove "./modules/identity/host/Identity.AuthServer/Identity.AuthServer.csproj" reference (Get-ChildItem -r **/*.csproj)
dotnet remove "./modules/identity/host/Identity.HttpApi.Host/Identity.HttpApi.Host.csproj" reference (Get-ChildItem -r **/*.csproj)

Move-Item -Path "./modules/identity/host/Identity.AuthServer" -Destination "./applications/AuthServer.Host" -Force
mv  "./applications/AuthServer.Host/Identity.AuthServer.csproj" "./applications/AuthServer.Host/AuthServer.Host.csproj"
dotnet add "./applications/AuthServer.Host/AuthServer.Host.csproj" reference "./modules/identity/src/Identity.Application.Contracts/Identity.Application.Contracts.csproj"
Move-Item -Path "./modules/identity/host/Identity.HttpApi.Host" -Destination "./microservices/IdentityService.Host" -Force
mv "./microservices/IdentityService.Host/Identity.HttpApi.Host.csproj" "./microservices/IdentityService.Host/IdentityService.Host.csproj"
Rename-Item -Path "./microservices/IdentityService.Host/IdentityHttpApiHostModule.cs" -NewName "IdentityServiceModule.cs"
dotnet add "./microservices/IdentityService.Host/IdentityService.Host.csproj" reference "./modules/identity/src/Identity.Application/Identity.Application.csproj"
dotnet add "./microservices/IdentityService.Host/IdentityService.Host.csproj" reference "./modules/identity/src/Identity.EntityFrameworkCore/Identity.EntityFrameworkCore.csproj"
dotnet add "./microservices/IdentityService.Host/IdentityService.Host.csproj" reference "./modules/identity/src/Identity.HttpApi/Identity.HttpApi.csproj"

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