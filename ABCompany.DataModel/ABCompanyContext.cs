using ABCompany.DataModel.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ABCompany.DataModel
{
    public class ABCompanyContext : DbContext, IDataContext
    {
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Complaints list
        /// </summary>
        /// <returns></returns>
        public DbSet<Complaint> GetComplaints()
        {
            return Complaints;
        }

        /// <summary>
        /// Users list
        /// </summary>
        /// <returns></returns>
        public DbSet<User> GetUsers()
        {
            return Users;
        }

        /// <summary>
        /// DB context
        /// </summary>
        /// <returns></returns>
        public DbContext GetDbContext()
        {
            return this;
        }
    }
}
