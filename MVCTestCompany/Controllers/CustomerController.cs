using System.Web;
using System.Web.Mvc;

namespace MVCTestCompany.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("ListAllCustomers", "Customer");
        }
        public ActionResult CustomerNumber(string id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Your Customer number is: " + id);
            return View();
        }
        public string Company(string name)
        {
            return HttpUtility.HtmlEncode("Your Company name is: " + name);
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
    }
}