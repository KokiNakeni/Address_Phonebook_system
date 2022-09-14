using ContactsAddressManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace ContactsAddressManagement.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactManagementContext _context;

        public ContactsController(ContactManagementContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _context.Contacts.Include(i => i.ContactAddress).ToListAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.Include(i => i.ContactAddress).FirstOrDefaultAsync(m => m.Id == id);

            if (contact == null)
            {
                return NotFound();
            }
            else
            {
                return View(contact);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Contact contact)
        {
            contact.Age = DateTime.Now.Year - contact.DateOfBirth.Year;

            await _context.Contacts.AddAsync(contact);

            await _context.SaveChangesAsync();

            return View("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (contact == null)
            {
                return NotFound();
            }
            else
            {
                _context.Contacts.Remove(contact);
                await _context.SaveChangesAsync();
                return View(contact);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Contact model)
        {
            if (model.Id == 0)
            {
                return NotFound();
            }

            _context.Contacts.Update(model);
            await _context.SaveChangesAsync();

            return View("index");
        }
    }
}
