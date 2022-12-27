using AutoKomis.Data;
using AutoKomis.DTO.Request;
using AutoKomis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoKomis.Controllers
{
    public class SprzedazController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SprzedazController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var lista = _db.Sprzedaze.ToList();
            return View(lista);
        }


        [HttpGet("CreateSprzedazGet")]
        public IActionResult CreateSprzedaz()
        {
            return View();
        }

        [HttpPost("CreateSprzedazPost")]
        public IActionResult CreateSprzedazPost(Sprzedaz sprzedaz) 
        {
            if (sprzedaz != null)
            {
                _db.Sprzedaze.Add(sprzedaz);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sprzedaz);
        }


        [HttpGet("UpdateSprzedaz")]
        public IActionResult UpdateSprzedaz(int id) 
        {
            if (id == null && id == 0) 
            {
                return NotFound();
            }
            var sprzedaz = _db.Sprzedaze.FirstOrDefault(x => x.IdSprzedazy == id);
            if (sprzedaz == null) 
            {
                return NotFound();
            }
            return View(sprzedaz);
        }


        [HttpPost("UpdateSprzedaz")]
        public IActionResult UpdateSprzedazPost(Sprzedaz sprzedaz)
        {

            if (sprzedaz.IdSprzedazy == null) 
            {
                return NotFound();
            }

            var obj = _db.Sprzedaze.Find(sprzedaz.IdSprzedazy);

            if (obj == null) 
            {
                return NotFound();
            }

            obj.IdSprzedazy = sprzedaz.IdSprzedazy;
            obj.IdSamochodu = sprzedaz.IdSamochodu;
            obj.IdPracownika = sprzedaz.IdPracownika;
            obj.IdKlienta = sprzedaz.IdKlienta;
            obj.DataZawarciaUmowy = sprzedaz.DataZawarciaUmowy;
            obj.Kwota = sprzedaz.Kwota;
            
            _db.Sprzedaze.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet("[Controller]/DeleteSprzedaz/{id}")]
        public IActionResult DeleteSprzedaz(int id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            var obj = _db.Sprzedaze.FirstOrDefault(x => x.IdSprzedazy == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Sprzedaze.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }



        [HttpGet("SzukajSprzedaży")]
        public IActionResult SzukajSprzedaży(DateTime rokPoczatku, DateTime rokKonca)
        {
            IEnumerable<Sprzedaz> result = from sprzedaz in _db.Sprzedaze
                         where sprzedaz.DataZawarciaUmowy > rokPoczatku && sprzedaz.DataZawarciaUmowy < rokKonca
                         select sprzedaz;

            return View(result);
        }

    }
}
