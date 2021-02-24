using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MemberClaimsService.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("MemberClaimsDB") { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Claim> Claims { get; set; }
    }
}