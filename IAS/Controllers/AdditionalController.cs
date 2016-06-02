using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IAS.Classes;

namespace IAS.Controllers
{
    public class AdditionalController : Controller
    {
        // GET: Additional
        public ActionResult UserProfile()
        {

            GetInfoUsers gif = new GetInfoUsers();
            Info inform = Info.getInfo();
            inform.AllInfo = gif.returninfo(User.Identity.Name);
            IASAModel iasm = new IASAModel();
            pathPhoto p = new pathPhoto();
            checkPhoto c = new checkPhoto();
            string pPath = p.setPath(inform.AllInfo["uName"]);
            iasm.sName = inform.AllInfo["sName"];
            iasm.fName = inform.AllInfo["fName"];
            iasm.mName = inform.AllInfo["mName"];
            iasm.department = inform.AllInfo["department"];
            iasm.pos = inform.AllInfo["pos"];
            iasm.phone = inform.AllInfo["phone"];
            iasm.photo = pPath;
            iasm.check = c.check(inform.AllInfo["uName"]);
            return View(iasm);
        }
    }
}