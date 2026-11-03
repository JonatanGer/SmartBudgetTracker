# Smart Budget Tracker

## Om projektet
Smart Budget Tracker är en webbapplikation där användaren kan hålla koll på sina inkomster och utgifter. Man kan lägga till, redigera och ta bort transaktioner samt se sitt totala saldo.

## Funktioner
- Lägga till inkomster och utgifter.
- Visa alla transaktioner.
- Redigera och ta bort transaktioner.
- Se totala inkomster och utgifter.
- Se aktuellt saldo.
- Se antal transaktioner.
- Välja kategori och datum.

## Tekniker
- C#
- .NET 9
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server LocalDB
- HTML, CSS och Bootstrap

## Databas
Applikationen använder SQL Server LocalDB för att spara transaktionerna. Informationen finns kvar även efter att programmet har stängts.

## AI som verktyg
Under utvecklingen har jag använt både ChatGPT och Claude som hjälpmedel.

AI-verktygen har använts för att:
- Få förklaringar av kod och programmering.
- Få hjälp med felsökning.
- Förstå hur olika delar av ASP.NET Core MVC fungerar.
- Få förslag på lösningar och förbättringar.
- Få hjälp med planering och strukturering av projektet.

AI har främst fungerat som ett stöd under arbetet. Jag har gått igenom kodförslag och använt dem för att lära mig mer om hur applikationen fungerar.

## Starta projektet
1. Öppna projektet i Visual Studio.
2. Kontrollera att projektet är valt som startprojekt.
3. Öppna Package Manager Console och kör:

```powershell
Update-Database
```

4. Starta programmet med F5.

## Utvecklare
Utvecklat som ett skolprojekt inom utbildningen Programutvecklare .NET.
