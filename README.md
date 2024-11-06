# abp.microservices
These are two scripts to create a template solution for microservices or add a new module to an existing solution with ABP framework 7.4 in macOS. Identity is a default service, so you don't need to declare this service when creating a solution.
Requeried powershell on macOS, If you don't have this tool, please install this tool at <a href="https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell-on-macos?view=powershell-7.4">here</a>

# Create new a solution
    Go to powershell with command : pwsh
    Create template : .\init.ps1 YourProjectName Service1 Service2 ...

# Add new module to an existing solution
    Go to powershell with command : pwsh
    Create template : .\module.ps1 YourProjectName Service1 Service2 ...
