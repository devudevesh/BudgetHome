using BudgetHome.Models;
using BudgetHome.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace BudgetHome.Controllers
{
    public class ExpenseController : Controller
    {
        private ApplicationDbContext dbContext;

        public ExpenseController()
        {
            dbContext = new ApplicationDbContext();
        }


        [HttpGet]
        [Authorize]
        public ActionResult Add()
        {
            ExpenseViewModel expenseViewModel = new ExpenseViewModel
            {
                PaymentModes = dbContext.PaymentModes.ToList()
            };

            if(TempData["ResponseMessage"] != null)
            {
                ViewData["ResponseMessage"] = TempData["ResponseMessage"];
                TempData["ResponseMessage"] = null;
            }
                

            return View(expenseViewModel);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Add(ExpenseViewModel expenseViewModel)
        {
            //if(!ModelState.IsValid)
            //{
            //    expenseViewModel.PaymentModes = dbContext.PaymentModes.ToList();
            //    return View(expenseViewModel);
            //}
                

            var transaction = new Transaction
            {
                Product = expenseViewModel.Product,
                PaidAmount = expenseViewModel.PaidAmount,
                PaymentModeId = expenseViewModel.PaymentModeId,
                BankName = expenseViewModel.BankName,
                TransactionType = "Debit",
                UserId = User.Identity.GetUserId(),
                TransactionDate = System.DateTime.Now
            };

            dbContext.Transactions.Add(transaction);
            dbContext.SaveChanges();

            TempData["ResponseMessage"] = "Success";

            return RedirectToAction("Add");
        }
    }
}