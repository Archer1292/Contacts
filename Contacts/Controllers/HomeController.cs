using Contacts.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Linq;

namespace Contacts.Controllers
{
    public class HomeController : Controller
    {
        ContactContext db = new ContactContext();
        public ActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(db.Contacts.OrderBy(c=>c.FullName).ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult Update(int? id)
        {
            if (id == null){return HttpNotFound();}

            Contact c = db.Contacts.Find(id);
            if (c == null) { return HttpNotFound(); }

           
            return View(c);
        }
     

        [HttpPost]
        public ActionResult Update(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();               
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            db.Contacts.Add(contact);
            
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) { return HttpNotFound(); }
            Contact c = db.Contacts.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact c = db.Contacts.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            db.Contacts.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    
    }
   
}