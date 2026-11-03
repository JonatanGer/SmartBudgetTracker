# Smart Budget Tracker
## Om projektet
Smart Budget Tracker är en webbapplikation där användaren kan hålla koll på sina inkomster och utgifter. Appen samlar alla transaktioner på ett ställe och räknar automatiskt ut totalerna och saldot.

Projektet är avgränsat till grundfunktionerna: registrera, visa, redigera och radera transaktioner samt enkla summeringar.

## Funktioner
- Lägga till inkomster och utgifter (beskrivning, belopp, kategori, typ och datum).
- Visa alla transaktioner, sorterade med det senaste datumet först.
- Redigera och ta bort transaktioner (med bekräftelse innan borttagning).
- Se totala inkomster, totala utgifter, saldo och antal transaktioner.
- Validering av formuläret.
   
## Tekniker
C#, .NET 9, ASP.NET Core MVC, Entity Framework Core 9, SQL Server LocalDB, Razor, HTML, CSS och Bootstrap.

## Förkunskaper
- Visual Studio 2022 med arbetsbelastningen ASP.NET och webbutveckling (innehåller SQL Server LocalDB)
- .NET 9 SDK

## Starta projektet
1. Öppna SmartBudgetTracker.sln i Visual Studio.

2. Öppna Package Manager Console (Verktyg > NuGet-pakethanterare > Package Manager Console) och kör:

```powershell
Update-Database
```
Kommandot skapar databasen och tabellen på din dator. Databasen är tom från början, eftersom den är lokal och inte följer med projektet. Detta måste göras innan första start.

3. Starta programmet med F5.

## Använda appen
1. Startsidan visar summeringskort och en tabell med alla transaktioner.
2. Klicka på Lägg till ny transaktion och fyll i formuläret.
3. Skriv belopp med komma, till exempel 49,50. Appen använder svenska talformat, så punkt godkänns inte.
4. Använd Redigera och Radera i tabellen för att ändra eller ta bort en transaktion.

## Testning
Applikationen har testats manuellt:

- Skapa, redigera och radera transaktioner
- Data finns kvar efter omstart av appen
- Summorna för inkomster, utgifter, saldo och antal stämmer
- Sortering efter datum
- Validering: tomma obligatoriska fält, belopp 0 eller negativt belopp och tomt datum nekas med felmeddelande

## AI som verktyg
Under utvecklingen har jag använt ChatGPT och Claude som hjälpmedel för att få förklaringar av kod, hjälp med felsökning, förslag på lösningar och hjälp med planering. Jag har gått igenom kodförslagen och använt dem för att lära mig hur applikationen fungerar.

I slutet av projektet lät jag Claude granska koden och köra appen.
