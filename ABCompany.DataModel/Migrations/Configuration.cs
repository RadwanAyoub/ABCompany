namespace ABCompany.DataModel.Migrations
{
    using ABCompany.DataModel.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ABCompany.DataModel.ABCompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ABCompany.DataModel.ABCompanyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var users = new User[]
            {
                new User { FirstName = "Carson",   LastName = "Alexander",
                    Email = "Carson@outlook.com", Password = "Carson@123" },
                new User { FirstName = "Meredith", LastName = "Alonso",
                    Email = "Meredith@outlook.com", Password = "Meredith@123" },
                new User { FirstName = "Arturo",   LastName = "Anand",
                    Email = "Arturo@outlook.com", Password = "Arturo@123" },
                new User { FirstName = "Gytis",    LastName = "Barzdukas",
                    Email = "Gytis@outlook.com", Password = "Gytis@123" }
            };

            foreach (User user in users)
                context.Users.Add(user);

            context.SaveChanges();

            var complaints = new Complaint[]
            {
                new Complaint { Title = "try to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Pending, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "how to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Pending, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "this to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Pending, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "low to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Pending, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "no to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Discard, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "work to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Discard, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "test to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Approved, Date = DateTime.Today, User = 2 },
                new Complaint { Title = "help to",   Description = "dasdagegswaegfasdfawe dasfs feagwe dfcsad",
                    State = DataModel.Enum.WorkflowState.Approved, Date = DateTime.Today, User = 2 },

            };

            foreach (Complaint complaint in complaints)
                context.Complaints.Add(complaint);

            context.SaveChanges();
        }
    }
}
