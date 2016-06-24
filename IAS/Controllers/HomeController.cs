using IAS.Models;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace IAS.Controllers
{
    public class HomeController : Controller
    {
        iasaContext db = new iasaContext();

        public ActionResult Index()
        {
            
            var mains = db.Mains.Include(m => m.User).Include(w => w.Worktype).ToList();
            mains.Reverse();
            return View(mains);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Активность пользователей";
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}