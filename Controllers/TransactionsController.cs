using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartBudgetTracker.Data;
using SmartBudgetTracker.Models;

namespace SmartBudgetTracker.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Hämtar databasanslutningen
        public TransactionsController(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            // Hämtar alla transaktioner och sorterar dem efter datum
            var transactions = await _context.Transactions
                .OrderByDescending(t => t.Date)
                .ToListAsync();

            // Räknar ihop inkomster och utgifter
            var income = transactions
                .Where(t => t.Type == "Income")
                .Sum(t => t.Amount);

            var expenses = transactions
                .Where(t => t.Type == "Expense")
                .Sum(t => t.Amount);

            // Räknar ut hur mycket pengar som är kvar
            var balance = income - expenses;

            // Skickar beloppen till webbsidan
            ViewBag.Income = income;
            ViewBag.Expenses = expenses;
            ViewBag.Balance = balance;
            ViewBag.TransactionCount = transactions.Count;

            return View(transactions);
        }


        // Visar formuläret för att lägga till en transaktion
        public IActionResult Create()
        {
            return View(new Transaction());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Transaction transaction)
        {
            // Kontrollerar att användaren fyllt i rätt information
            if (ModelState.IsValid)
            {
                // Lägger till transaktionen i databasen
                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();

                // Går tillbaka till listan med transaktioner
                return RedirectToAction("Index");
            }

            // Visar formuläret igen om något är fel
            return View(transaction);
        }


        // Visar sidan där användaren bekräftar borttagningen
        public async Task<IActionResult> Delete(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // Raderar transaktionen efter bekräftelse
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        // Visar formuläret för att redigera en transaktion
        public async Task<IActionResult> Edit(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // Sparar ändringarna i databasen
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Transaction transaction)
        {
            if (id != transaction.Id)
            {
                return NotFound();
            }

            // Kontrollerar att informationen är giltig
            if (ModelState.IsValid)
            {
                _context.Transactions.Update(transaction);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(transaction);
        }



    }
}
