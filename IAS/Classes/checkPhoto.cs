using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAS.Classes
{
    public class checkPhoto
    {
        public bool check(string Name)
        {
            var relativePath = "~/Content/Avatars/" + Name + ".jpg";
            //HttpContext http = new HttpContext(null);
            bool check = false;
            var absolutePath = HttpContext.Current.Server.MapPath(relativePath);
            if (System.IO.File.Exists(absolutePath))
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;

        }
    }
}