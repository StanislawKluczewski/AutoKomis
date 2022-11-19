using AutoKomis.Data;
using AutoKomis.DTO.Response;
using AutoKomis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoKomis.Controllers
{
    public class AutoController : Controller
    {

        private readonly ApplicationDbContext _db;

        public AutoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var lista = _db.Auta.ToList();
            return View(lista);
        }

        [HttpGet("CreateAuto")]
        public IActionResult CreateAuto()
        {
            return View();
        }

        [HttpPost("CreateAuto")]
        public IActionResult CreateAutoPost(Auto auto)
        {
            if (auto != null)
            {
                _db.Auta.Add(auto);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(auto);
            }

        }

        [HttpGet("[Controller]/UpdateAuto/{id}")]
        public IActionResult UpdateAuto(int id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            var auto = _db.Auta.FirstOrDefault(x => x.IdSamochodu == id);
            if (auto == null)
            {
                return NotFound();
            }
            return View(auto);
        }


        [HttpPost("[Controller]/UpdateAutoPost")]
        public IActionResult UpdateAutoPost(Auto auto)
        {
            if (auto.IdSamochodu == null && auto.IdSamochodu == 0)
            {
                return NotFound();
            }

            var obj = _db.Auta.FirstOrDefault(x => x.IdSamochodu == auto.IdSamochodu);
            
            if (obj == null)
            {
                return NotFound();
            }

            obj.IdSamochodu = auto.IdSamochodu;
            obj.IdKomisu = auto.IdKomisu;
            obj.IdSprzedazy = auto.IdSprzedazy;
            obj.Marka = auto.Marka;
            obj.Model = auto.Model;
            obj.RokProdukcji = auto.RokProdukcji;
            obj.Vin = auto.Vin;
            obj.Przebieg = auto.Przebieg;
            obj.Cena = auto.Cena;
            obj.Kolor = auto.Kolor;
            obj.PojemnoscSilnika = auto.PojemnoscSilnika;
            obj.TypNadwozia = auto.TypNadwozia;
            obj.RodzajPaliwa = auto.RodzajPaliwa;
            obj.Segment = auto.Segment;
            obj.IloscDrzwi = auto.IloscDrzwi;
            obj.CzyDostepny = auto.CzyDostepny;

            _db.Auta.Update(obj); 
            _db.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet("DeleteAuto")]
        public IActionResult DeleteAuto(int id)
        {
            var obj = _db.Auta.FirstOrDefault(x => x.IdSamochodu == id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Auta.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       [HttpGet("ZnajdzAutoOdpowiednieParametry")]
        public IActionResult ZnajdzAutoOdpowiednieParametry(string marka, string paliwo)
        {
            if (marka == "" && paliwo == "")
            {
                return RedirectToAction("Index");
            }
            else
            {
                var obj = _db.Auta.FirstOrDefault(x => x.Marka == marka );
                if (obj == null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var result = from auto in _db.Auta
                                 where auto.Marka == obj.Marka && auto.RodzajPaliwa == paliwo 
                                 select new AutoResponse
                                 {
                                     Marka = auto.Marka,
                                     Model = auto.Model,
                                     RokProdukcji = auto.RokProdukcji,
                                     Przebieg = auto.Przebieg,
                                     Cena = auto.Cena,
                                     Kolor = auto.Kolor,
                                     PojemnoscSilnika = auto.PojemnoscSilnika,
                                     TypNadwozia = auto.TypNadwozia,
                                     RodzajPaliwa = auto.RodzajPaliwa,
                                     Vin = auto.Vin,
                                     CzyDostepny = auto.CzyDostepny,
                                     Segment = auto.Segment,
                                     IloscDrzwi = auto.IloscDrzwi
                                 };
                    return View(result);
                }
            }
        }

        [HttpGet("SzukajDostepnychSamochodow")]
        public IActionResult SzukajDostepnychSamochodow() 
        {
            var lista = _db.Auta.FirstOrDefault(x => x.CzyDostepny == true);
            
            if (lista == null)
            {
                return NotFound();
            }

            var result = from auto in _db.Auta
                         where auto.CzyDostepny == lista.CzyDostepny
                         select auto;

            return View(result);  
        }
    }
}
