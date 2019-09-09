using AgaHotelMVC.Models;
using AgaHotelMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgaHotelMVC.Controllers
{
    public class ReceptionController : BaseController
    {
        // GET: Reception
        public ActionResult NewOrder()
        {
            return View();
        }
        public ActionResult Rooms()
        {

            List<Room> rooms = _context.Rooms.ToList();
            return View(rooms);
        }

        public ActionResult AddRoom()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddRoom(Room room)
        {

            if (room.File.ContentType != "image/png" && room.File.ContentType != "image/jpeg")
            {
                ModelState.AddModelError("File", "Siz png və ya jpg faylı yükləyə bilərsiniz");
                Console.WriteLine("asaxsa");

            }

            if (room.File.ContentLength / 1024 / 1024 > 1)
            {
                ModelState.AddModelError("File", "Siz max 1 mblıq yükləyə bilərsiniz");
                Console.WriteLine("asaxsa");
            }

            if (ModelState.IsValid)
            {
                var texts = room.File.FileName.Split('.');
                room.Photo = Guid.NewGuid().ToString() + "." + texts[texts.Length - 1];

                string path = Path.Combine(Server.MapPath("/wwwroot/images/roomimg"), room.Photo);

                room.File.SaveAs(path);

                _context.Rooms.Add(room);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }

            return View(room);
        }
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Search(SearchList search)
        {
            SearchPage page = new SearchPage
            {
                room = _context.Rooms.ToList(),
                customer = _context.Customers.ToList()

            };

            return View(page);
        }
    }
}