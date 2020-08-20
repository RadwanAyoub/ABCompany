using System.Data.Entity.Migrations;

namespace ABCompany.DataModel.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ABCompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ABCompanyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
