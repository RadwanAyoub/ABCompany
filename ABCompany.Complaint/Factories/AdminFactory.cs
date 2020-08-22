using ABCompany.Complaint.ViewModels;
using ABCompany.DataModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace ABCompany.Complaint.Factories
{
    public class AdminFactory : IAdminFactory
    {
        /// <summary>
        /// Generates admin view model
        /// </summary>
        /// <param name="user">User object</param>
        /// <param name="complaints">Complaint object</param>
        /// <returns></returns>
        public AdminViewModel GetAdminPage(List<User> user, List<DataModel.Models.Complaint> complaints)
        {
            var adminModel = new AdminViewModel();

            if (!user.Any() || !complaints.Any()) return adminModel;

            adminModel.Complaint = new ComplaintViewModel { Complaints = complaints, Description = "dasdasfgefas", Title = "Complaints" };
            adminModel.Users = user;

            return adminModel;
        }
    }
}