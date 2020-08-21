using ABCompany.Complaint.ViewModels;
using ABCompany.DataModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace ABCompany.Complaint.Factories
{
    public class AdminFactory : IAdminFactory
    {
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