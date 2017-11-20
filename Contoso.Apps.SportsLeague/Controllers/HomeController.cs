using Contoso.Apps.SportsLeague.Web.Models;
using System.Web.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Contoso.Apps.SportsLeague.Controllers
{
    public class HomeController : Controller {
        public ActionResult Index() {
            //var orderId = 1;
            //var order = new Order();
            //using (var orderActions = new OrderActions(orderId))
            //{
            //    order = orderActions.GetOrder();
            //}

            var vm = new HomeModel();

            return View(vm);
        }

        [Authorize]
        public ActionResult Claims()
        {
            Claim displayName = ClaimsPrincipal.Current.FindFirst(ClaimsPrincipal.Current.Identities.First().NameClaimType);
            ViewBag.DisplayName = displayName != null ? displayName.Value : string.Empty;
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}