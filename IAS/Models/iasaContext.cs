using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IAS.Models
{
    public class iasaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<Worktype> Worktypes { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}