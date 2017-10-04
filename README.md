
### Digitalent arbetsprov
## DIGITALENT – CASE FRONTEND
### INTRODUKTION
Caset innebär att du ska skapa en webapplikation som gör det möjligt att på ett smidigt sätt
hantera konsulter. 
### Följande konsultinformation ska gå att ta fram i applikationen:
	Namn
	Ålder
	Email
	Adress
	Kompetenser
	Bild
	Information om personen har uppdrag eller ej



### I APPLIKATIONEN SKA DET GÅ ATT:
	Se en lista med konsulter
	Söka bland konsulter
	Ta bort konsulter
	Lägga till konsulter
	Uppdatera en befintlig konsults information
	Visa detalj-vy för en specifik konsult
	Filtrera konsultlistan på kompetenser

### ÖVRIGT
Backend kan lämpligen sättas upp med C# eller Node.js.
Frontend kan sättas upp med lämpliga ramverk och tekniker.
Lösningen bör vara responsiv och vi ger extra plus för styling, arkitektur, och innovation.


## Migrations
in Digitalent\DigitalentCooreApp.Domain>
dotnet ef --startup-project ../DigitalentCoreApp/ migrations add InitialCreate
dotnet ef --startup-project ../DigitalentCoreApp/ database update 


## drop db
dotnet ef --startup-project ../DigitalentCoreApp/ database drop