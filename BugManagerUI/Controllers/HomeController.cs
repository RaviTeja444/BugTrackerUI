using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BugManagerUI.Models;
using Microsoft.AspNetCore.Identity;
using BugManagerUI.Utility;
using BugManagerUI.Interface;

namespace BugManagerUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IUtility utility;


        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IUtility _utility)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            utility = _utility;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Login()
        {

            return View();
        }

        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult RegisterDetails(Register register)
        {
            var user = new ApplicationUser()
            {
                //Name = register.FirstName + register.LastName,
                Email = register.Email,
                PhoneNumber = register.Contact,
                //Organization=register.Organization,
                //Gender=register.Gender,
                //Password=register.Password,
                UserName = register.FirstName + register.LastName

            };

            var result = userManager.CreateAsync(user, register.Password);
            if (result.Result.Succeeded)
            {
                return View("~/Views/Home/User.cshtml", user);
            }
            else
            {
                return View("~/Views/Shared/Error.cshtml");
            }

        }
        [HttpPost]
        public async Task<IActionResult> CheckLogin(Login login)
        {
            var token = utility.Token();
            utility.callAPI(token);
            ApplicationUser user = await userManager.FindByNameAsync(login.UserName);
            var result = await signInManager.PasswordSignInAsync(user, login.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return View("~/Views/Home/User.cshtml", user);
            }
            else
            {
                return View("~/Views/Shared/Error.cshtml");
            }

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View("User");
        }

        [HttpGet]
        public JsonResult Contact()
        {

            return Json(new { result = "Hello World From ReactJS Controller" });
            //ViewData["Message"] = "Your contact page.";

            //return View();
        }
        [HttpPost]
        public string CreateUser(Project project)
        {
            var token = utility.Token();
            var res = utility.createProject(project.Organization, project.ProjectName, Convert.ToString(project.ProjectSize), token);
            return "success";
        }

        public IActionResult NewProject()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CreateUserStory(UserStory userStory)
        {
            var token = utility.Token();
            var res = utility.createUserStory(userStory.UserStoryName,userStory.Priority,userStory.Points,userStory.Description,userStory.Comments,"",token);
            return View();
            
        }

        [HttpPost]
        public IActionResult CreateDefect(Defect defect)
        {
            var token = utility.Token();
            var res = utility.createDefect(defect.DefectName,defect.Priority,defect.UserStoryNumber,defect.Description,defect.Comments,"",token);
            return View();
        }

        public IActionResult Dashboard()
        {
            var token = utility.Token();
            var res = utility.GetDashboard(token);
            return View(res);
        }

        public IActionResult SaveUS(string usname,string usno,string usstatus,string usdesc)
        {
            var token = utility.Token();
            var res = utility.saveUS(usname,usno,usstatus,usdesc,token);
            return View(res);
        }

        public IActionResult SaveDefect(string defname, string defno, string defstatus, string defdesc)
        {
            var token = utility.Token();
            var res = utility.saveDefect(defname,defno,defstatus,defdesc,token);
            return View(res);
        }
    }
}
