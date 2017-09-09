using LanSiDai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanSiDai.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (LansidaiDB db = new LansidaiDB())
            {


                var result = db.Questions.OrderByDescending(a => a.CreatTime).Select(a => a).ToList();
                return View(result);
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

        public ActionResult AskQuestion()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AskQuestion(Questions question)
        {
            using (LansidaiDB db = new LansidaiDB())
            {
                db.Questions.Add(question);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
        }

    }
}