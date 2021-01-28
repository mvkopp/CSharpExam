using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcConcert.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcConcert.Controllers
{
    public class ConcertsController : Controller
    {
        private static List<Concert> Concerts = new List<Concert>
        {
            new Concert
            {
                Id = 1,
                Nom = "Francis Cabrel",
                Salle = "théatre royal de Mons",
                EventDate = new DateTime(2021,03,23)
            },
            new Concert
            {
                Id = 2,
                Nom = "Lara Fabian",
                Salle = "accordhotels arena de Bercy",
                EventDate = new DateTime(2021,06,11)
            },
            new Concert
            {
                Id = 3,
                Nom = "The Weeknd",
                Salle = "accordhotels arena de Bercy",
                EventDate = new DateTime(2021,11,17)
            },
            new Concert
            {
                Id = 4,
                Nom = "André Rieu",
                Salle = "Palais des sports d'Anvers",
                EventDate = new DateTime(2021,01,10)
            }
        };

        // GET: /<controller>/
        public IActionResult Index(string searchString)
        {
            var concerts = from m in Concerts
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                concerts = concerts.Where(s => s.Nom.Contains(searchString));
            }

            return View(concerts);
        }

        // GET: Concerts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Concerts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Nom,Salle,EventDate")] Concert concert)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    // Solution du prof
                    var index = Concerts.Max(m => m.Id) + 1;

                    // Set the index
                    concert.Id = index;

                    Concerts.Add(concert);
                    return RedirectToAction(nameof(Index));
                }
                return View(concert);

            }
            catch
            {
                return View();
            }
        }

        // GET: Concerts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concert = Concerts.Single(m => m.Id == id.Value);
            if (concert == null)
            {
                return NotFound();
            }
            return View(concert);
        }

        // POST : Concerts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Nom,Salle,EventDate")] Concert concert)
        {
            if (id != concert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var concertToUpdate = Concerts.Single(m => m.Id == id);

                    concertToUpdate.Nom = concert.Nom;
                    concertToUpdate.Salle = concert.Salle;
                    concertToUpdate.EventDate = concert.EventDate;
                }
                catch
                {
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(concert);
        }

        // GET: Concerts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concert = Concerts.FirstOrDefault(m => m.Id == id.Value);
            if (concert == null)
            {
                return NotFound();
            }

            return View(concert);
        }

        // POST: Concerts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var concert = Concerts.Single(m => m.Id == id);
                Concerts.Remove(concert);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
