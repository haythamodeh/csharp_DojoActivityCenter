using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExamBelt.Models;
using Microsoft.AspNetCore.Http;


namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {

        private ExamContext dbContext;

        public HomeController(ExamContext context)
        {
            dbContext = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }
            List<AnActivity> AllActivities = dbContext.Activities
                .Include(a => a.AllParticipants)
                .ThenInclude(u => u.User)
                .OrderBy(c => c.Date)
                .ToList();

            User retreivedUser = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
            ViewBag.User = retreivedUser;

            // Participant userThatCreatedActivity = dbContext.Participants
            //     .Include(x => x.Activity)
            //     .FirstOrDefault(a => a.UserID == userID);

            //     ViewBag.whomadeit = userThatCreatedActivity;
                // userThatCreatedActivity.
            // int? ActivityID = HttpContext.Session.GetInt32("LastActivityCreated_activityID");

            // AnActivity retreivedActivity = dbContext.Activities
            //     .Include(g => g.AllParticipants)
            //     .ThenInclude(u => u.User)
            //     .FirstOrDefault(a => a.ActivityID == ActivityID);
            // // User whomadeit = AllActivities.FirstOrDefault(u => u.UserID == userID);
            // ViewBag.whomadeit = dbContext.Users.FirstOrDefault(u => u.UserID == retreivedActivity.UserID);

            return View("dashboard", AllActivities);
        }

        [HttpPost("login")]
        public IActionResult LoginValidate(LogRegWrapper LogRegWrapper)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == LogRegWrapper.Login.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(LogRegWrapper.Login, userInDb.Password, LogRegWrapper.Login.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Index");
                }   
                HttpContext.Session.SetInt32("userID", userInDb.UserID);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already taken");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("userID", user.UserID);
                return RedirectToAction("Dashboard");
            }
            else
                return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }




        ///////////////////////////////////////////////////////////////////

        [HttpGet("activity/new")]
        public IActionResult NewActivity()
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }

            return View("NewActivity");
        }
        [HttpPost("activity/NewActivity")]
        public IActionResult CreateActivity(AnActivity newActivity)
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }
            User retreivedUser = dbContext.Users.FirstOrDefault(u => u.UserID == userID);


            // System.Console.WriteLine(newActivity.Date);
            // System.Console.WriteLine(newActivity.Time);
            System.Console.WriteLine(ModelState.IsValid);
            if(ModelState.IsValid)
            {
                if(newActivity.Time < DateTime.Now)
                {
                    ModelState.AddModelError("Date", "Date needs to be in the future!");
                    return View("NewActivity");
                }
                newActivity.CreatorNameFirst = retreivedUser.FirstName;
                newActivity.CreatorNameLast = retreivedUser.LastName;
                newActivity.UserID = (int)userID;
                dbContext.Activities.Add(newActivity);
                dbContext.SaveChanges();
                // System.Console.WriteLine(newActivity.ActivityID);
                // HttpContext.Session.SetInt32("LastActivityCreated_activityID", newActivity.ActivityID);
                return RedirectToAction("Dashboard");  
            }   
            return View("NewActivity");
        }

        [HttpGet("view/activity/{ActivityID}")]
        public IActionResult ViewActivity(int ActivityID)
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }
            AnActivity retreivedActivity = dbContext.Activities
                .Include(g => g.AllParticipants)
                .ThenInclude(u => u.User)
                .FirstOrDefault(a => a.ActivityID == ActivityID);

            // System.Console.WriteLine(DateTime.Now);
            // System.Console.WriteLine(retreivedActivity.Date);
            if(DateTime.Now > retreivedActivity.Time)
            {
                TempData["passedDue"] = "Activity has unfortunately finished";
                return RedirectToAction("DeleteActivity", new{ActivityID = ActivityID});
            }

            User retreivedUser = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
            ViewBag.User = retreivedUser;

            ViewBag.whomadeit = dbContext.Users.FirstOrDefault(u => u.UserID == retreivedActivity.UserID);

            return View("ViewActivity", retreivedActivity);
        }



        [HttpGet("delete/activity/{ActivityID}")]
        public IActionResult DeleteActivity(int ActivityID)
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }
            AnActivity retreivedActivity = dbContext.Activities.FirstOrDefault(a => a.ActivityID == ActivityID);
            dbContext.Activities.Remove(retreivedActivity);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("join/activity/{ActivityID}")]
        public IActionResult JoinActivity(int ActivityID)
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }
            AnActivity retreivedActivity = dbContext.Activities.FirstOrDefault(a => a.ActivityID == ActivityID);
            Participant newJoin = new Participant();
            newJoin.UserID = (int)userID; 
            newJoin.ActivityID = retreivedActivity.ActivityID;
            newJoin.Activity = retreivedActivity;
            newJoin.User = dbContext.Users.FirstOrDefault(u => u.UserID == userID);
            dbContext.Add(newJoin);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("leave/activity/{ActivityID}")]
        public IActionResult LeaveActivity(int ActivityID)
        {
            int? userID = HttpContext.Session.GetInt32("userID");
            if(userID == null)
            {
                TempData["error"] = "You need to be logged in to view this page";
                return RedirectToAction("Index");
            }
            Participant leave = dbContext.Participants
                .Where(a => a.ActivityID == ActivityID)
                .FirstOrDefault(u => u.UserID == userID);
                dbContext.Remove(leave);
                dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}
