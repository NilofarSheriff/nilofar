using _06OctoberAssignement_Adomvc_modelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06OctoberAssignement_Adomvc_modelBinding.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        List<BookModel> BookList = new List<BookModel>();
        public BookController()
        {
            
            BookList.Add(new BookModel {BookNo=101,BookName="Ponniyin Selvan",Author="Kalki",Price=450,Category="History"});
            BookList.Add(new BookModel {BookNo=102,BookName="Tomorrow Comes",Author="Ihit whit",Price=850,Category="Novel"});
            BookList.Add(new BookModel { BookNo = 103, BookName = "Alchemist", Author = "Paul celheo", Price = 384, Category = "Novel" });
            BookList.Add(new BookModel { BookNo = 104, BookName = "Mahabrat", Author = "Kambar", Price = 550, Category = "History" });
            
        }

    
        public ActionResult Index()
        {
            ViewData["Listb"] = BookList;
            return View();
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
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

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
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
