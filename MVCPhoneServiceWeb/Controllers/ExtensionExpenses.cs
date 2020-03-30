using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Repo;
using System.Linq;
using Data.ViewModels;

namespace MVCPhoneServiceWeb.Controllers
{
    public class ExtensionExpenses : Controller
    {
        private ApplicationDbContext _context;

        public ExtensionExpenses(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var model = from lpc in _context.LandLinePhoneCalls
                group lpc by new {Extension = lpc.Extension}
                into g
                select new ExtensionExpense()
                {
                    Extension = g.Key.Extension,
                    Expense = g.Sum(a => a.LandlinePhoneCallCost)
                };
            IEnumerable<ExtensionExpense> viewModel = model;
            return View(model);
        }
    }
}