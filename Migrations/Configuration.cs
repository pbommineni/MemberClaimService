namespace MemberClaimsService.Migrations
{
    using CsvHelper;
    using MemberClaimsService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MemberClaimsService.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MemberClaimsService.Models.DatabaseContext context)
        {
            using (var reader = new StreamReader(".\\Files\\Member.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Member>();

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Members ON");
                context.Members.AddRange(records);
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Members] OFF");
                context.SaveChanges();

                base.Seed(context);
            }

            using (var reader = new StreamReader(".\\Files\\Claim.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Claim>();

                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Claims ON");
                context.Claims.AddRange(records);
                context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Claims] OFF");
                context.SaveChanges();

                base.Seed(context);
            }
        }
    }
}
