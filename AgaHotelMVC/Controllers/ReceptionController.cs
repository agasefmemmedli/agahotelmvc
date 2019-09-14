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

        


        public ActionResult RoomsSearch(string txt)
        {
            List<Room> rooms = _context.Rooms.Where(r=>r.Number.ToString().Contains(txt)).ToList();

            return PartialView("_RoomSearchList", rooms);
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
            }

            if (room.File.ContentLength / 1024 / 1024 > 1)
            {
                ModelState.AddModelError("File", "Siz max 1 mblıq yükləyə bilərsiniz");
            }

            if (_context.Rooms.Any(r => r.Number == room.Number))
            {
                ModelState.AddModelError("Number", "Bu nömrədə otaq artiq var");

            }
            if (ModelState.IsValid)
            {
                
                var texts = room.File.FileName.Split('.');
                room.Photo = Guid.NewGuid().ToString() + "." + texts[texts.Length - 1];

                string path = Path.Combine(Server.MapPath("/wwwroot/images/roomimg"), room.Photo);

                room.File.SaveAs(path);

                _context.Rooms.Add(room);
                _context.SaveChanges();

                return RedirectToAction("rooms","reception");

            }

            return View(room);
        }



        public ActionResult UpdateRoom(int Id)
        {
            Room room = _context.Rooms.Find(Id);

            if (room == null)
            {
                return HttpNotFound();
            }

            return View(room);
        }


        [HttpPost]
        public ActionResult UpdateRoom(Room room)
        {
            
            if (room.File != null)
            {
                if (room.File.ContentType != "image/png" && room.File.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("File", "Siz png və ya jpg faylı yükləyə bilərsiniz");
                }

                if (room.File.ContentLength / 1024 / 1024 > 1)
                {
                    ModelState.AddModelError("File", "Siz max 1 mblıq yükləyə bilərsiniz");
                }
            }

            if (ModelState.IsValid)
            {
                if (room.File != null)
                {
                    System.IO.File.Delete(Path.Combine(Server.MapPath("/wwwroot/images/roomimg"), room.Photo));

                    var texts = room.File.FileName.Split('.');
                    room.Photo = Guid.NewGuid().ToString() + "." + texts[texts.Length - 1];

                    string path = Path.Combine(Server.MapPath("/wwwroot/images/roomimg"), room.Photo);

                    room.File.SaveAs(path);
                }

                _context.Entry(room).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("rooms");
            }



            return View(room);
        }
        public ActionResult DeleteRoom(int Id)
        {
            Room room = _context.Rooms.FirstOrDefault(r => r.Id == Id);
            if (room == null)
            {
                return HttpNotFound();
            }
            _context.Rooms.Remove(room);
            _context.SaveChanges();
            return RedirectToAction("rooms");
        }

        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Search(SearchInSearch search = null)
        {

            SearchPage page = new SearchPage
            {
                room = _context.Rooms.ToList(),
                customer = _context.Customers.ToList()

            };

            if (search == null) {
               
                return View(page);
            }
            if (ModelState.IsValid){

            }
            return View(page);
        }
    }
}