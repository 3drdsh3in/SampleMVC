using System.Linq;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private ProductDbContext db = new ProductDbContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetProducts()
        {
            // I used very basic LINQ to SQL to convert the Products DataSet into a usable array. (The search query doesn't seem to be convoluted enough to justify filtering anything)
            return new JsonResult { Data = db.Products.ToArray(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpPost]
        public JsonResult PostProduct(CreateProductViewModel productViewModel)
        {
            try
            {
                tblProduct product = new tblProduct();
                product.Id = 101;
                product.Name = productViewModel.Name;
                product.Price = productViewModel.Price;
                db.Products.Add(product);
                db.SaveChanges();
                return new JsonResult { Data = "Done" };
            } catch {
                return new JsonResult { Data = "Failed" };
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}