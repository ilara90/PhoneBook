using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index(int? id)
        {
            IEnumerable<Person> persons = db.Persons;

            return View(persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            db.Persons.Add(person);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Person person = await db.Persons.FirstOrDefaultAsync(p => p.Id == id);
                if (person != null)
                {
                    db.Persons.Remove(person);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetPerson(int? id)
        {
            Person? person = await db.Persons.FirstOrDefaultAsync(u => u.Id == id);

            if (person == null) return NotFound(new { message = "Контакт не найден" });

            return Json(person);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            db.Persons.Update(person);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
