using AutoKomis.Data;
using AutoKomis.DTO.Request;
using AutoKomis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoKomis.Controllers
{
    public class PracownikController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PracownikController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var lista = _db.Pracownicy.ToList();
            return View(lista);
        }

        [HttpGet("CreatePracownik")]
        public IActionResult CreatePracownik()
        {
            return View();
        }

        [HttpPost("CreatePracownik")]
        public IActionResult CreatePracownikPOST(Pracownik pracownik)
        {
            if (pracownik != null)
            {
                _db.Pracownicy.Add(pracownik);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pracownik);
        }


        [HttpGet("UpdatePracownik")]
        public IActionResult UpdatePracownik(int id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            var pracownik = _db.Pracownicy.FirstOrDefault(x => x.IdPracownika == id);
            if (pracownik == null)
            {
                return NotFound();
            }
            return View(pracownik);
        }


        [HttpPost("UpdatePracownik")]
        public IActionResult UpdatePracownikPost(Pracownik pracownik)
        {
            if (pracownik.IdPracownika == null)
            {
                return NotFound();
            }

            // var obj = _db.Pracownicy.FirstOrDefault(x => x.IdPracownika == id);
            var obj = _db.Pracownicy.Find(pracownik.IdPracownika);
            if (obj == null)
            {
                return NotFound();
            }

            obj.IdPracownika = pracownik.IdPracownika;
            obj.IdKomisu = pracownik.IdKomisu;
            obj.NrDowodu = pracownik.NrDowodu;
            obj.Stanowisko = pracownik.Stanowisko;
            obj.Imie = pracownik.Imie;
            obj.Nazwisko = pracownik.Nazwisko;

            _db.Pracownicy.Update(obj);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet("DeletePracownik")]
        public IActionResult DeletePracownik(int id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            var obj = _db.Pracownicy.FirstOrDefault(x => x.IdPracownika == id);
            if (obj == null)
            {
                return NotFound();
            }


            return View(obj);
        }

        [HttpGet("[Controller]/DeletePracownikPost/{id}")]
        public IActionResult DeletePracownikPost(int id)
        {
            var obj = _db.Pracownicy.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Pracownicy.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet("ZnajdzPracownika")]
        public IActionResult ZnajdzPracownika(string _stanowisko)
        {
            var obj = _db.Pracownicy.FirstOrDefault(x => x.Stanowisko == _stanowisko);
            if (obj == null)
            {
                return RedirectToAction("Index");
            }

            IEnumerable<Pracownik> result = from pracownik in _db.Pracownicy
                                            where pracownik.Stanowisko == _stanowisko
                                            select pracownik;

            return View(result);
        }

    }
}
