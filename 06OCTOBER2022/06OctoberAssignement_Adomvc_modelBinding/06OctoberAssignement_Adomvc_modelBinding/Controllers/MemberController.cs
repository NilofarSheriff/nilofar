using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _06OctoberAssignement_Adomvc_modelBinding.Models;

namespace _06OctoberAssignement_Adomvc_modelBinding.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        

        static List<MemberModel> MemberList = new List<MemberModel>();

        static MemberController()
        {
            MemberList.Add(new MemberModel { MemberId=1,MemberName="Nilofar",Account_open_Date=new DateTime(2001,10,27),PenaltyAmount=0,MaxBooks=8});
            MemberList.Add(new MemberModel { MemberId = 2, MemberName = "Zamruth", Account_open_Date = new DateTime(2002, 12, 11), PenaltyAmount = 0, MaxBooks = 8 });
            MemberList.Add(new MemberModel { MemberId = 3, MemberName = "Mehar", Account_open_Date = new DateTime(1974, 11, 07), PenaltyAmount = 0, MaxBooks = 8 });
            MemberList.Add(new MemberModel { MemberId = 4, MemberName = "M K Sheriff", Account_open_Date = new DateTime(1962, 06, 09), PenaltyAmount = 0, MaxBooks = 8 });
            MemberList.Add(new MemberModel { MemberId = 5, MemberName = "Asif", Account_open_Date = new DateTime(1954, 04, 07), PenaltyAmount = 0, MaxBooks = 8 });
            
        
        
        }

        public ActionResult GetDetails()
        {
            ViewBag.ListMem = MemberList;
            return View();
        }
        public ActionResult Index()
        {
            
            return View(MemberList);
        }

        public ActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(MemberModel M)
        {
            MemberList.Add(M);
            return RedirectToAction("Index");
        }

        public ActionResult EditMember(int id)
        {
            MemberModel found = MemberList.Find(x => x.MemberId == id);
            return View(found);


        }
        [HttpPost]
        public ActionResult EditMember(MemberModel M,int id)
        {
            MemberModel found = MemberList.Find(x => x.MemberId == id);
            MemberList.Remove(found);
            MemberList.Add(M);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteMember(int id)
        {
            MemberModel found = MemberList.Find(x => x.MemberId == id);
            return View(found);
        }
        [HttpPost]
        public ActionResult DeleteMember(int id,MemberModel M)
        {
            MemberModel found = MemberList.Find(x => x.MemberId == id);
            MemberList.Remove(found);
            return RedirectToAction("Index");
        }

        //public ActionResult AddMember()
        //{
        //    return View();
        //}
    }
}