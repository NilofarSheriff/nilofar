using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _11OCTOBERAssignments.Models;

namespace _11OCTOBERAssignments.Controllers
{
    public class Book : Controller
    {
        // GET: Book
        List<BookModel> BookList = new List<BookModel>();
        public Book()
        {

            BookList.Add(new BookModel { BookNo = 101, BookName = "Ponniyin Selvan", Author = "Kalki", Price = 450, Category = "History" });
            BookList.Add(new BookModel { BookNo = 102, BookName = "Tomorrow Comes", Author = "Ihit whit", Price = 850, Category = "Novel" });
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
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
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
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
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
