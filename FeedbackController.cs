
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Feedback", new Feedback { Rating = 5 });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Feedback feedback)
        {
            if (!ModelState.IsValid)
                return View("Feedback", feedback);

            ViewBag.Submitted = true;
            ViewBag.Name = feedback.Name;
            ViewBag.Email = feedback.Email;
            ViewBag.Category = feedback.Category;
            ViewBag.Rating = feedback.Rating;
            ViewBag.Comments = feedback.Comments;

            return View("Feedback", feedback);
        }
    }
}
