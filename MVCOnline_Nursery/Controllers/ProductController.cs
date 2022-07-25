using MVCOnline_Nursery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Text;

namespace MVCOnline_Nursery.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;
        public ProductController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = _dbContext.productDemos.ToList();
            return View(products);
        }
        public ActionResult Details(int id)
        {
            var product = _dbContext.productDemos.Include(p => p.CategoriesDemo).FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categoies = _dbContext.productDemos.ToList();
            ViewBag.productDemos = categoies;
            return View();
           
        }
    }
}