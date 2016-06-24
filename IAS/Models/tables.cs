using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IAS.Models
{
    public class User
    {
        public int Id { get; set; }      
        public string Guid { get; set; }
        public string DomainName { get; set; }
        public string FIO { get; set; }
        public ICollection<Main> Mains { get; set; }
        public User()
        {
            Mains = new List<Main>();
        }
    }

    public class Main
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public int? WorktypeId { get; set; }
        public Worktype Worktype { get; set; }
        public string Comment { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public int? DivisionId { get; set; }
        public Division Division { get; set; }
        public int? ActivityId { get; set; }
        public Activity Activity { get; set; }
        public DateTime Create { get; set; }
    }

    public class Worktype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Main> Mains { get; set; }
        public Worktype()
        {
            Mains = new List<Main>();
        }
    }

    public class Division
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Main> Mains { get; set; }
        public Division()
        {
            Mains = new List<Main>();
        }
    }

    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public ICollection<Main> Mains { get; set; }
        public Activity()
        {
            Mains = new List<Main>();
        }
    }
}
