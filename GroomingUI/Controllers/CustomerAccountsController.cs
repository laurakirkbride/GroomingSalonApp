using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GroomingSalonApp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace GroomingUI.Controllers
{
    [Authorize]
    public class CustomerAccountsController : Controller
    {
    
        // GET: CustomerAccounts
        public IActionResult Index()
        {
            return View(Salon.GetCustomerAccounts(HttpContext.User.Identity.Name));
        }

        // GET: CustomerAccounts/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerAccount = Salon.GetCustomerAccountDetails(id.Value);
            if (customerAccount == null)
            {
                return NotFound();
            }

            return View(customerAccount);
        }

        // GET: CustomerAccounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("EmailAddress,CustomerFN,CustomerLN,StreetAddress,City,State,Zip,PhoneNumber")] CustomerAccount customerAccount)
        {
            if (ModelState.IsValid)
            {
                Salon.CreateCustomerAccount(customerAccount.EmailAddress, customerAccount.CustomerFN, customerAccount.CustomerLN, customerAccount.StreetAddress, customerAccount.City, customerAccount.State, customerAccount.Zip, customerAccount.PhoneNumber);
                return RedirectToAction(nameof(Index));
            }
            return View(customerAccount);
        }

        // GET: CustomerAccounts/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerAccount = Salon.GetCustomerAccountDetails(id.Value);
            if (customerAccount == null)
            {
                return NotFound();
            }
            return View(customerAccount);
        }

        // POST: CustomerAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CustomerId,EmailAddress,CustomerFN,CustomerLN,StreetAddress,City,State,Zip,PhoneNumber")] CustomerAccount customerAccount)
        {
            if (id != customerAccount.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Salon.EditAccount(customerAccount);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Salon.CustomerAccountExists(customerAccount.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customerAccount);
        }

        // GET: CustomerAccounts/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerAccount = Salon.GetCustomerAccountDetails(id.Value);
            if (customerAccount == null)
            {
                return NotFound();
            }

            return View(customerAccount);
        }

        // POST: CustomerAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Salon.DeleteCustomerAccount(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
