using System;
using System.Linq;
using System.Web.Mvc;
using IAS.Classes;
using IAS.Models;
using System.IO;
using System.Data.Entity;

namespace IAS.Controllers
{
    public class AdditionalController : Controller
    {
        // GET: Additional
        iasaContext db = new iasaContext();

        public ActionResult UserProfile()
        {
            var mains = db.Mains.Include(m => m.User).Include(w => w.Worktype).ToList();
            mains.Reverse();
            try
            {
                mains = mains.GetRange(0, 10);
            }
            catch (Exception)
            {

            }
            

            foreach (string upload in Request.Files)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "Content/Avatars/";
                string filename = Path.GetFileName(Request.Files[upload].FileName);
                Request.Files[upload].SaveAs(Path.Combine(path, filename));
            }

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

            iasm.records = mains;

            return View(iasm);
        }


    }
}