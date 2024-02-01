$name = $args[0]
dotnet new sln -n "$name"

mkdir "./applications"
mkdir "./microservices" 

dotnet new web -n "AdminGateway.Host" -o "gateways/AdminGateway.Host"
dotnet new web -n "InternalGateway.Host" -o "gateways/InternalGateway.Host"
dotnet new web -n "PublicGateway.Host" -o "gateways/PublicGateway.Host"

dotnet new classlib -n "$name.Shared" -o "shared/$name.Shared"
dotnet new classlib -n "$name.EventBus" -o "shared/$name.EventBus"
dotnet new classlib -n "$name.Permisson" -o "shared/$name.Permisson"
dotnet new classlib -n "$name.Security" -o "shared/$name.Security"

abp new "Identity" -t module --no-ui -o "modules/identity"
Copy-Item -Path "./modules/identity/common.props" -Destination "./common.props" -Force
dotnet remove "./modules/identity/host/Identity.AuthServer/Identity.AuthServer.csproj" reference (Get-ChildItem -r **/*.csproj)
dotnet remove "./modules/identity/host/Identity.HttpApi.Host/Identity.HttpApi.Host.csproj" reference (Get-ChildItem -r **/*.csproj)

Copy-Item -Path "./modules/identity/host/Identity.AuthServer" -Destination "./applications/AuthServer.Host" -Force
mv  "./applications/AuthServer.Host/Identity.AuthServer.csproj" "./applications/AuthServer.Host/AuthServer.Host.csproj"
dotnet add "./applications/AuthServer.Host/AuthServer.Host.csproj" reference "./modules/identity/src/Identity.Application.Contracts/Identity.Application.Contracts.csproj"
Copy-Item -Path "./modules/identity/host/Identity.HttpApi.Host" -Destination "./microservices/IdentityService.Host/" -Force
mv "./microservices/IdentityService.Host/Identity.HttpApi.Host.csproj" "./microservices/IdentityService.Host/IdentityService.Host.csproj"
dotnet add "./microservices/IdentityService.Host/IdentityService.Host.csproj" reference "./modules/identity/src/Identity.Application/Identity.Application.csproj"
dotnet add "./microservices/IdentityService.Host/IdentityService.Host.csproj" reference "./modules/identity/src/Identity.EntityFrameworkCore/Identity.EntityFrameworkCore.csproj"
dotnet add "./microservices/IdentityService.Host/IdentityService.Host.csproj" reference "./modules/identity/src/Identity.HttpApi/Identity.HttpApi.csproj"

for (($i = 1); $i -lt $args.length; $i++)
{
    $modulename = (Get-Culture).TextInfo.ToTitleCase($args[$i].ToLower())
    $modulepath = $args[$i].ToLower()
    $moduleservice = $modulename + "Service"
    abp new $modulename -t module --no-ui -o "modules/$modulepath" 

    # Move-Item -Path "./modules/$modulepath/host/$modulename.HttpApi.Host" -Destination "./microservices/$moduleservice.Host/" -Force
    # mv "./microservices/$moduleservice.Host/$modulename.HttpApi.Host.csproj" "./microservices/$moduleservice.Host/$moduleservice.Host.csproj"
}

# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB.Tests)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Host.Shared)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Installer)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/host)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/database)

dotnet sln "./$name.sln" add (Get-ChildItem -r **/*.csproj)


# Move-Item -Path "./modules/identity/host/Identity.AuthServer" -Destination "./applications/AuthServer.Host/" -Force
# mv  "./applications/AuthServer.Host/Identity.AuthServer.csproj" "./applications/AuthServer.Host/AuthServer.Host.csproj"
# Move-Item -Path "./modules/identity/host/Identity.HttpApi.Host" -Destination "./microservices/IdentityService.Host/" -Force
# mv "./microservices/IdentityService.Host/Identity.HttpApi.Host.csproj" "./microservices/IdentityService.Host/IdentityService.Host.csproj"
# Move-Item -Path "./modules/notification/host/Notification.HttpApi.Host" -Destination "./microservices/NotificationService.Host/" -Force
# mv "./microservices/NotificationService.Host/Notification.HttpApi.Host.csproj" "./microservices/NotificationService.Host/NotificationService.Host.csproj"

# Move-Item -Path "./modules/saas/host/SaaS.HttpApi.Host" -Destination "./microservices/SaaSService.Host/" -Force
# mv "./microservices/SaaSService.Host/SaaS.HttpApi.Host.csproj" "./microservices/SaaSService.Host/SaaSService.Host.csproj"

# abp new "$name" -t app -u angular -dbms PostgreSQL -m none --separate-identity-server --database-provider ef -csf -o "temp"
# Move-Item -Path "./temp/$name/aspnet-core/src/$name.DbMigrator" -Destination "./shared/" -Force
# Move-Item -Path "./temp/$name/aspnet-core/src/$name.IdentityServer" -Destination "./applications/" -Force
# Remove-Item -Recurse -Force "./temp/"
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Installer.csproj)
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Host.Shared.csproj)
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.csproj)
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.Tests.csproj)
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.AdministrationService.IdentityServer.csproj)
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.IdentityService.IdentityServer.csproj)
# dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.SaaSService.IdentityServer.csproj)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.SaaSService.IdentityServer)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.IdentityService.IdentityServer)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.AdministrationService.IdentityServer)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB.Tests)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Host.Shared)
# Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Installer)
# abp add-module Volo.AuditLogging -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations
# abp add-module Volo.FeatureManagement -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations
# abp add-module Volo.PermissionManagement -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations
# abp add-module Volo.SettingManagement -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations

# abp add-module Volo.Identity -s "microservices/identity/$name.IdentityService.sln" --skip-db-migrations
# abp add-module Volo.IdentityServer -s "microservices/identity/$name.IdentityService.sln" --skip-db-migrations

# abp add-module Volo.TenantManagement -s "microservices/saas/$name.SaaSService.sln" --skip-db-migrations
