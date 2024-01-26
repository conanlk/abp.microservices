$name = $args[0]
dotnet new web -n "AdminGateway.Host" -o "gateways/AdminGateway.Host"
dotnet new web -n "InternalGateway.Host" -o "gateways/InternalGateway.Host"
dotnet new web -n "PublicGateway.Host" -o "gateways/PublicGateway.Host"

dotnet new classlib -n "$name.Shared" -o "shared/$name.Shared"
dotnet new classlib -n "$name.EventBus" -o "shared/$name.EventBus"
dotnet new classlib -n "$name.Permisson" -o "shared/$name.Permisson"
dotnet new classlib -n "$name.Security" -o "shared/$name.Security"

abp new "Identity" -t module --no-ui -o "modules/identity"
abp new "Notification" -t module --no-ui -o "modules/notification"
abp new "SaaS" -t module --no-ui -o "modules/saas"

mkdir "./applications"
mkdir "./microservices"

Move-Item -Path "./modules/identity/host/Identity.AuthServer" -Destination "./applications/AuthServer.Host/" -Force
mv  "./applications/AuthServer/Identity.AuthServer.csproj" "./applications/AuthServer/AuthServer.csproj"
Move-Item -Path "./modules/identity/host/Identity.HttpApi.Host" -Destination "./microservices/IdentityService.Host/" -Force
mv "./microservices/IdentityService.Host/Identity.HttpApi.Host" "./microservices/IdentityService.Host/IdentityService.Host/"
Move-Item -Path "./modules/notification/host/Notification.HttpApi.Host" -Destination "./microservices/NotificationService.Host/" -Force
mv "./microservices/NotificationService.Host/Notification.HttpApi.Host" "./microservices/NotificationService.Host/NotificationService.Host"
Move-Item -Path "./modules/saas/host/SaaS.HttpApi.Host" -Destination "./microservices/SaaSService.Host/" -Force
mv "./microservices/SaaSService.Host/SaaS.HttpApi.Host" "./microservices/SaaSService.Host/SaaSService.Host"

dotnet new sln -n "$name"
dotnet sln "./$name.sln" add (Get-ChildItem -r **/*.csproj)

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
