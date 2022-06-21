using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UNOESC.BL;
using UNOESCWeb.Models;

namespace UNOESCWeb.Controllers
{
    public class CustomerAddressController : Controller
    {
        private readonly UNOESCDbContext _context;

        public CustomerAddressController(UNOESCDbContext context)
        {
            _context = context;
        }

        // GET: CustomerAddress
        public async Task<IActionResult> Index()
        {
            var uNOESCDbContext = _context.CustomerAddresses.Include(c => c.Address).Include(c => c.Customer);
            return View(await uNOESCDbContext.ToListAsync());
        }

        // GET: CustomerAddress/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerAddress = await _context.CustomerAddresses
                .Include(c => c.Address)
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerAddress == null)
            {
                return NotFound();
            }

            return View(customerAddress);
        }

        // GET: CustomerAddress/Create
        public IActionResult Create()
        {
            ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Street");
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName");
            return View();
        }

        // POST: CustomerAddress/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerId,AddressId")] CustomerAddress customerAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Street", customerAddress.AddressId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName", customerAddress.CustomerId);
            return View(customerAddress);
        }

        // GET: CustomerAddress/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerAddress = await _context.CustomerAddresses.FindAsync(id);
            if (customerAddress == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "FirstName", customerAddress.AddressId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "Street", customerAddress.CustomerId);
            return View(customerAddress);
        }

        // POST: CustomerAddress/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerId,AddressId")] CustomerAddress customerAddress)
        {
            if (id != customerAddress.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerAddressExists(customerAddress.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Addresses, "Id", "Street", customerAddress.AddressId);
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "FirstName", customerAddress.CustomerId);
            return View(customerAddress);
        }

        // GET: CustomerAddress/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerAddress = await _context.CustomerAddresses
                .Include(c => c.Address)
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerAddress == null)
            {
                return NotFound();
            }

            return View(customerAddress);
        }

        // POST: CustomerAddress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerAddress = await _context.CustomerAddresses.FindAsync(id);
            _context.CustomerAddresses.Remove(customerAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerAddressExists(int id)
        {
            return _context.CustomerAddresses.Any(e => e.Id == id);
        }
    }
}
