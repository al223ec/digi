
### Digitalent arbetsprov
## DIGITALENT � CASE FRONTEND
### INTRODUKTION
Caset inneb�r att du ska skapa en webapplikation som g�r det m�jligt att p� ett smidigt s�tt
hantera konsulter. 
### F�ljande konsultinformation ska g� att ta fram i applikationen:
	Namn
	�lder
	Email
	Adress
	Kompetenser
	Bild
	Information om personen har uppdrag eller ej



### I APPLIKATIONEN SKA DET G� ATT:
	Se en lista med konsulter
	S�ka bland konsulter
	Ta bort konsulter
	L�gga till konsulter
	Uppdatera en befintlig konsults information
	Visa detalj-vy f�r en specifik konsult
	Filtrera konsultlistan p� kompetenser

### �VRIGT
Backend kan l�mpligen s�ttas upp med C# eller Node.js.
Frontend kan s�ttas upp med l�mpliga ramverk och tekniker.
L�sningen b�r vara responsiv och vi ger extra plus f�r styling, arkitektur, och innovation.


## Migrations
in Digitalent\DigitalentCooreApp.Domain>
dotnet ef --startup-project ../DigitalentCoreApp/ migrations add InitialCreate
dotnet ef --startup-project ../DigitalentCoreApp/ database update 


## drop db
dotnet ef --startup-project ../DigitalentCoreApp/ database drop