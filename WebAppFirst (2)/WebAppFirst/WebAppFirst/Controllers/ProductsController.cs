using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppFirst.Models;

namespace WebAppFirst.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            if (Session["UserName"] == null) // Tässä tarkastetaan onko käyttäjä kirjautunut sisään
            {
                return RedirectToAction("login", "home");
            }else
            {
                northwindEntities1 db = new northwindEntities1();
                List<Products> model = db.Products.ToList();
                db.Dispose();
                return View(model);
            }   
        }

        public ActionResult Index2()
        {
            northwindEntities1 db = new northwindEntities1();
            List<Products> model = db.Products.ToList();
            db.Dispose();
            return View(model);
        }
    }
}