using _06OctoberAssignement_Adomvc_modelBinding.Models;
using DAL_Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06OctoberAssignement_Adomvc_modelBinding.Controllers
{
    public class LibBookController : Controller
    {
        // GET: LibBook
        
        public ActionResult Index()
        {
            BookModel book = new BookModel();
            List<BookModel> booklist = book.showBooks();
            return View(booklist);
        }

        // GET: LibBook/Details/5
        public ActionResult Details(int id)
        {
            BookModel model = new BookModel();
            BookModel Book = model.search(id);
            return View(Book);
        }

        // GET: LibBook/Create
        public ActionResult Create()
        {  return View();
        }

        // POST: LibBook/Create
        [HttpPost]
        public ActionResult Create(BookModel Book)
        {
            try
            {
                // TODO: Add insert logic here
                BookModel model = new BookModel();
                model.add(Book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LibBook/Edit/5
        public ActionResult Edit(int id)
        {
            BookModel model = new BookModel();
            BookModel Book = model.search(id);
            return View(Book);
        }

        // POST: LibBook/Edit/5
        [HttpPost]
        public ActionResult Edit(BookModel Book)
        {
            try
            {
                // TODO: Add update logic here

                BookModel model = new BookModel();
                model.UpdateBook(Book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LibBook/Delete/5
        public ActionResult Delete(int id)
        {
            BookModel Book = new BookModel();
            if(id == 0)
            {
                Response.Write("Null Request");
            }
            else
            {
                BookModel model=new BookModel();
                Book = model.search(id);
                
            }
            return View(Book);

        }

        // POST: LibBook/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BookModel Book,int id)
        {
            try
            {
                // TODO: Add delete logic here

                BookModel model = new BookModel();
                Book = model.search(id);
                model.DeleteBook(Book);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {

                return View(ex.Message);
            }
        }
    }
}
