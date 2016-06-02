using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Web;

namespace IAS.Classes
{
    public class GetInfoUsers
    {
        public Dictionary<string, string> returninfo(string Name)
        {
            Dictionary<string, string> AllInfo = new Dictionary<string, string>();
            try
            {

                string DomainName = Name;
                string[] SP = DomainName.Split('\\');
                string uDomain = SP[0];
                string uName = SP[1];
                AllInfo.Add("uName", uName);

                List<LdapUser> lUser = new List<LdapUser>();
                List<string> lstr = new List<string>();
                PrincipalContext pc = new PrincipalContext(ContextType.Domain, uDomain); ;
                UserPrincipal principal = null;

                try
                {
                    principal = UserPrincipal.FindByIdentity(pc, DomainName);
                    string fullName = principal.DisplayName;
                    string[] splitName = fullName.Split(' ');
                    AllInfo.Add("sName", splitName[0]);
                    AllInfo.Add("fName", splitName[1]);
                    AllInfo.Add("mName", splitName[2]);

                    AllInfo.Add("department", principal.Description);
                    AllInfo.Add("pos", principal.GetTitle());
                    AllInfo.Add("phone", principal.VoiceTelephoneNumber);
                    if (principal != null) principal.Dispose();
                }
                finally
                {
                    if (principal != null) principal.Dispose();
                    if (pc != null) pc.Dispose();
                }
            }
            catch (Exception)
            {
                //AllInfo.Add("uName", "pupkin_vv");
                AllInfo.Add("sName", "Пупкин");
                AllInfo.Add("fName", "Василий");
                AllInfo.Add("mName", "Васьльевич");

                AllInfo.Add("department", "Ректорат");
                AllInfo.Add("pos", "Самый главный");
                AllInfo.Add("phone", "11-11");
            }



            return AllInfo;
        }
    }
}