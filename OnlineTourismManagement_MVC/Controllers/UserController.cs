using System.Web.Mvc;
using OnlineTourismManagement.Entity;
using OnlineTourismManagement.DAL;
namespace OnlineTourismManagement_MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(UserDetails user)
        {
            UserRepository.AddUser(user);
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }
    }
}