using ABCompany.Complaint.ViewModels;
using ABCompany.DataModel.Models;
using System.Collections.Generic;

namespace ABCompany.Complaint.Factories
{
    public interface IAdminFactory
    {
        AdminViewModel GetAdminPage(List<User> user, List<DataModel.Models.Complaint> complaints);
    }
}
