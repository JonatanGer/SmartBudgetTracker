
using Microsoft.EntityFrameworkCore;
using SmartBudgetTracker.Data;

var builder = WebApplication.CreateBuilder(args);

// Gör så att appen alltid använder svenska tal- och datumformat, oavsett datorns inställning
System.Globalization.CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("sv-SE");
System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = new System.Globalization.CultureInfo("sv-SE");

// Lägger till stöd för MVC
builder.Services.AddControllersWithViews();

// Kopplar applikationen till databasen
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Hanterar fel när appen inte körs i utvecklingsläge
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Använder HTTPS och tillåter CSS, JavaScript och bilder
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();


// Öppnar budgetöversikten som startsida
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Transactions}/{action=Index}/{id?}");


app.Run();
