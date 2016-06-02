using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAS.Classes
{
    public class LdapUser
    {
        public string SamAccountName { get; set; }
        public string GivName { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public string VoiceTelephoneNumber { get; set; }
    }
}