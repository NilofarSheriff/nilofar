using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _11OCTOBERAssignments.Models;
using System.Security.Cryptography;

namespace _11OCTOBERAssignments.Controllers
{
    public class ProductController : Controller
    {
        static List<ProductModel> productlist = new List<ProductModel>();
        private readonly ITransient _transient1;
        private readonly ISingleton _singleton;
       public ProductController(ITransient t1,ISingleton s1)
        {
            _transient1 = t1;
            _singleton = s1;
            ViewBag.Prodid = _singleton.GetDetailsPro();
            //productlist.Add(new ProductModel { Proid =_transient1.GetProductId() ,ProdName = "Rice", Price = 58, MfgDate = new DateTime(2022, 01, 13) });;
            //productlist.Add(new ProductModel { Proid = _transient1.GetProductId() ,ProdName = "Wheat", Price = 40, MfgDate = new DateTime(2022, 02, 14) });
            //productlist.Add(new ProductModel { Proid = _transient1.GetProductId() ,ProdName = "Sugar", Price = 55, MfgDate = new DateTime(2022, 03, 09) });
            productlist.Add(new ProductModel { Proid = 1, ProdName = "Rice", Price = 58, MfgDate = new DateTime(2022, 01, 13) }); ;
            productlist.Add(new ProductModel { Proid = 2, ProdName = "Wheat", Price = 40, MfgDate = new DateTime(2022, 02, 14) });
            productlist.Add(new ProductModel { Proid = 3, ProdName = "Sugar", Price = 55, MfgDate = new DateTime(2022, 03, 09) });



        }

        public ActionResult Index()
        {

            return View(productlist);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            ProductModel M = new ProductModel();
            M = productlist.Find(X => X.Proid == id)!;
            return View(M);
        }

        // GET: Product/Create
        public ActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddProduct(FormCollection Products)
        {
            try
            {
                ProductModel M = new ProductModel();
                M.Proid = Convert.ToInt32(Products["Prodid"]);
                M.ProdName = Products["Prodname"];
                M.Price = Convert.ToInt32(Products["Price"]);
                M.MfgDate = Convert.ToDateTime(Products["MfgDate"]);
                productlist.Add(M);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //Product/FindProduct/1
        public ActionResult FindProduct(int id)
        {
            ProductModel Found = new ProductModel();
            
            Found = productlist.Find(x => x.Proid == id)!;
            

            return View(Found);

        }

        //[HttpPost]
        //public ActionResult FindProduct(int id,FormCollection Products)
        //{
        //    try
        //    {
        //        ProductModel Found = productlist.Find(x => x.Proid == id);

        //        return View(Found);
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
