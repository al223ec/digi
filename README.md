
in Digitalent\DigitalentCooreApp.Domain>

## Migrations
dotnet ef --startup-project ../DigitalentCoreApp/ migrations add InitialCreate
dotnet ef --startup-project ../DigitalentCoreApp/ database update 


## drop db
dotnet ef --startup-project ../DigitalentCoreApp/ database drop