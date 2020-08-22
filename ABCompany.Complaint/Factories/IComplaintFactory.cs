using ABCompany.Complaint.ViewModels;
using System.Collections.Generic;

namespace ABCompany.Complaint.Factories
{
    public interface IComplaintFactory
    {
        IndexViewModel GenerateIndexViewModel(List<DataModel.Models.Complaint> complaints);
        UserViewModel GenerateUserViewModel(List<DataModel.Models.Complaint> complaints, string Id);
    }
}
