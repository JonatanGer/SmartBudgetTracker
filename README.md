Smart Budget Tracker
Om projektet
Smart Budget Tracker är en webbapplikation där användaren kan hålla koll på sina inkomster och utgifter. Appen samlar alla transaktioner på ett ställe och räknar automatiskt ut totalerna och saldot.

Projektet är avgränsat till grundfunktionerna: registrera, visa, redigera och radera transaktioner samt enkla summeringar.

Funktioner
Lägga till inkomster och utgifter (beskrivning, belopp, kategori, typ och datum).
Visa alla transaktioner, sorterade med det senaste datumet först.
Redigera och ta bort transaktioner (med bekräftelse innan borttagning).
Se totala inkomster, totala utgifter, saldo och antal transaktioner.
Validering av formuläret.
Tekniker
C#, .NET 9, ASP.NET Core MVC, Entity Framework Core 9, SQL Server LocalDB, Razor, HTML, CSS och Bootstrap.

Förkunskaper
Visual Studio 2022 med arbetsbelastningen ASP.NET och webbutveckling (innehåller SQL Server LocalDB)
.NET 9 SDK
Starta projektet
Öppna SmartBudgetTracker.sln i Visual Studio.

Öppna Package Manager Console (Verktyg > NuGet-pakethanterare > Package Manager Console) och kör:

Update-Database
Kommandot skapar databasen och tabellen på din dator. Databasen är tom från början, eftersom den är lokal och inte följer med projektet. Detta måste göras innan första start.

Starta programmet med F5.

Använda appen
Startsidan visar summeringskort och en tabell med alla transaktioner.
Klicka på Lägg till ny transaktion och fyll i formuläret.
Skriv belopp med komma, till exempel 49,50. Appen använder svenska talformat, så punkt godkänns inte.
Använd Redigera och Radera i tabellen för att ändra eller ta bort en transaktion.
Testning
Applikationen har testats manuellt:

Skapa, redigera och radera transaktioner
Data finns kvar efter omstart av appen
Summorna för inkomster, utgifter, saldo och antal stämmer
Sortering efter datum
Validering: tomma obligatoriska fält, belopp 0 eller negativt belopp och tomt datum nekas med felmeddelande
Begränsningar
Ingen inloggning, alla transaktioner delas i samma databas.
Databasen skapas inte automatiskt (Update-Database måste köras först).
Vissa felmeddelanden från ramverket (till exempel för ogiltigt belopp) visas på engelska.
Inga automatiska tester.
AI som verktyg
Under utvecklingen har jag använt ChatGPT och Claude som hjälpmedel för att få förklaringar av kod, hjälp med felsökning, förslag på lösningar och hjälp med planering. Jag har gått igenom kodförslagen och använt dem för att lära mig hur applikationen fungerar.

I slutet av projektet lät jag Claude granska koden och köra appen.
