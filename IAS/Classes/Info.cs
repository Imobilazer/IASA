using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace IAS.Classes
{
    public class Info
    {

        private Info() { }
        private static Info inf = new Info();
        public static Info getInfo()
        {
             return inf;
        }

        public Dictionary<string, string> AllInfo;
       
    }
}