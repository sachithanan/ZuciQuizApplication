using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZuciQuizLibrary.Models;

namespace ZuciQuizMVC.Controllers
{
    public class ScoreController : Controller
    {
        public ActionResult Details()
        {
            int userId = (int)HttpContext.Session.GetInt32("userId");
            string UserName = HttpContext.Session.GetString("userName");
            int topicId = (int)HttpContext.Session.GetInt32("TopicId");
            int totalQuestions = (int)HttpContext.Session.GetInt32("Count");
            int correctCount = (int)HttpContext.Session.GetInt32("Mark");
            double score = (double)correctCount / totalQuestions * 100;
            Score score1 = new Score();
            score1.Mark = (int)score;
            score1.UserId = userId;
            score1.TopicId = topicId;
            score1.DateCompleted = DateTime.Now;
            return View(score1);
        }
    }
}
