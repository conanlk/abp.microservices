$name = $args[0]

dotnet new web -n "$name.IdentityServer" -o "applications/$name.IdentityServer"
dotnet new web -n "$name.Gateway" -o "gateway/$name.Gateway"
dotnet new classlib -n "$name.Shared.Hosting" -o "shared/$name.Shared.Hosting"
dotnet new console -n "$name.DbMigrator" -o "shared/$name.DbMigrator"
abp new "$name.AdministrationService" -t module --no-ui -o "microservices/administration"
abp new "$name.IdentityService" -t module --no-ui -o "microservices/identity"
abp new "$name.SaaSService" -t module --no-ui -o "microservices/saas"
dotnet new sln -n "$name"
dotnet sln "./$name.sln" add (Get-ChildItem -r **/*.csproj)
abp new "$name" -t app -u angular -dbms PostgreSQL -m none --separate-identity-server --database-provider ef -csf -o "temp"
Move-Item -Path "./temp/$name/aspnet-core/src/$name.DbMigrator" -Destination "./shared/" -Force
Move-Item -Path "./temp/$name/aspnet-core/src/$name.IdentityServer" -Destination "./applications/" -Force
Remove-Item -Recurse -Force "./temp/"
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Installer.csproj)
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.Host.Shared.csproj)
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.csproj)
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.MongoDB.Tests.csproj)
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.AdministrationService.IdentityServer.csproj)
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.IdentityService.IdentityServer.csproj)
dotnet sln "./$name.sln" remove (Get-ChildItem -r **/*.SaaSService.IdentityServer.csproj)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.SaaSService.IdentityServer)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.IdentityService.IdentityServer)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.AdministrationService.IdentityServer)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB.Tests)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.MongoDB)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Host.Shared)
Remove-Item -Recurse -Force (Get-ChildItem -r **/*.Installer)
abp add-module Volo.AuditLogging -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations
abp add-module Volo.FeatureManagement -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations
abp add-module Volo.PermissionManagement -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations
abp add-module Volo.SettingManagement -s "microservices/administration/$name.AdministrationService.sln" --skip-db-migrations

abp add-module Volo.Identity -s "microservices/identity/$name.IdentityService.sln" --skip-db-migrations
abp add-module Volo.IdentityServer -s "microservices/identity/$name.IdentityService.sln" --skip-db-migrations

abp add-module Volo.TenantManagement -s "microservices/saas/$name.SaaSService.sln" --skip-db-migrations
