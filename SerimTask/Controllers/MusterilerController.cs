using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SerimTask.Models;

namespace SerimTask.Controllers
{
    public class MusterilerController : Controller
    {
        private readonly Context _context;
        public MusterilerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Musteri> musteriList = _context.Musteriler;
            return View(musteriList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                musteri.Durum = true;
                musteri.KayitTarihi = DateTime.Now;
                _context.Musteriler.Add(musteri);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musteri);
        }

        public JsonResult GetById(int? id)
        {
            var musteri = _context.Musteriler.Find(id);
            return Json(musteri);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.Musteriler.Find(id);

            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        public IActionResult Edit(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                _context.Musteriler.Update(musteri);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Updated Successfully !";
                return RedirectToAction("Index");
            }

            return View(musteri);
        }

        public IActionResult Delete(int? id, bool? aktif)
        {
            var deleterecord = _context.Musteriler.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            deleterecord.Durum = aktif;
            //_context.Musteriler.Remove(deleterecord);
            _context.SaveChanges();
            return Ok();
        }
    }
}
