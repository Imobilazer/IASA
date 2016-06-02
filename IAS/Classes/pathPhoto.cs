using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAS.Classes
{
    public class pathPhoto
    {
        public string setPath(string Name)
        {
            var relativePath = "~/Content/Avatars/" + Name + ".jpg";
            //HttpContext http = new HttpContext(null);
            string path = "";
            var absolutePath = HttpContext.Current.Server.MapPath(relativePath);
            if (System.IO.File.Exists(absolutePath)) {
                path =  "/Content/Avatars/" + Name + ".jpg";
            } else
            {
                path =  "/Content/Avatars/nophoto.jpg";
            }
            return path;

        }
        
    }
}