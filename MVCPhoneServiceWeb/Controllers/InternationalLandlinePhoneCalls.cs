using System.Collections.Generic;
using System.Linq;
using Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Repo;

namespace MVCPhoneServiceWeb.Controllers
{
    public class InternationalLandlinePhoneCalls : Controller
    {
        private ApplicationDbContext _context;

        public InternationalLandlinePhoneCalls(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index(string month,string year)
        {
            int _month = Utils.Utils.IntTryParse(month);
            int _year = Utils.Utils.IntTryParse(year);

            var model = from lpc in _context.LandLinePhoneCalls
                join e in _context.Employees
                    on lpc.EmployeeId equals e.EmployeeId
                    where lpc.LandlinePhoneCallDateTime.Month==_month &&
                          lpc.LandlinePhoneCallDateTime.Year == _year &&
                          lpc.Destination !="Cuba"
                group lpc by new
                {
                    Extension = lpc.Extension,
                    EmployeeId = e.EmployeeId,
                    EmployeeName = e.EmployeeName,
                    CostCenter = e.CostCenter
                }
                into g
                select new InternationalLandlinePhoneCall()
                {
                    Extension = g.Key.Extension,
                    CostCenter = g.Key.CostCenter,
                    EmployeeId = g.Key.EmployeeId,
                    EmployeeName = g.Key.EmployeeName,
                    Expense = g.Sum(a => a.LandlinePhoneCallCost),
                };
            float totalExpense = 0;
            foreach (var item in model)
            {
                totalExpense += item.Expense;
            }

            foreach (var item in model)
            {
                item.Percent = (item.Expense / totalExpense) * 100;
            }

            IEnumerable<InternationalLandlinePhoneCall> viewModel = model;   
            return View(model);
        }
    }
}