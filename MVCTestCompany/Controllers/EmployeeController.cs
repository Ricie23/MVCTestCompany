using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            }
            else
            {
                return View();

            }
        }

        public ContentResult Search(string name)
        {
            var input = HttpUtility.HtmlEncode(name);
            return Content(input);
        }
        public string ListAllCustomers()
        {
            return @"<ul>
            <li>George Kaborge</li>
            <li>John Jinglehheimershmidt</li>
            <li>Robert Bobson</li>
            <li>Susie McDoosie</li>
            </ul>";
        }
        [HttpPost]
        public ActionResult NewEmployee(string firstName, string lastName, string title)
        {
            ViewBag.Message = "Name: " + firstName + " " + lastName;
            ViewBag.Message += " Title: " + title;
            return View("ConfirmEmployee");
        }
        public ActionResult NewEmployee()
        {
            return View("NewEmployeeForm");
        }
    }
}