using _06OctoberAssignement_Adomvc_modelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06OctoberAssignement_Adomvc_modelBinding.Controllers
{
    public class IssueController : Controller
    {
        // GET: Issue
        List<IssueModel> IssueList = new List<IssueModel>();
        public IssueController()
        {
            IssueList.Add(new IssueModel { IssueId=1001,BookNo=101,MemberId = 1,Issue_Date=new DateTime
                (2022,01,21),Return_Date=new DateTime(2022,02,21)});
            IssueList.Add(new IssueModel
            {
                IssueId = 1002,
                BookNo = 102,
                MemberId = 2,
                Issue_Date = new DateTime
                (2021, 11, 21),
                Return_Date = new DateTime(2021, 12, 21)
            });
            IssueList.Add(new IssueModel
            {
                IssueId = 1003,
                BookNo = 101,
                MemberId = 4,
                Issue_Date = new DateTime
                (2022, 04, 05),
                Return_Date = new DateTime(2022, 05, 05)
            });

        }
        public ActionResult Index()
        {
            TempData["MyIssueList"] = IssueList;
            return View();
        }

        // GET: Issue/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Issue/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Issue/Create
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

        // GET: Issue/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Issue/Edit/5
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

        // GET: Issue/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Issue/Delete/5
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
