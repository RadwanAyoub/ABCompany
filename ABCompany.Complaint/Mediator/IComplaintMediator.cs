using System.Collections.Generic;

namespace ABCompany.Complaint.Mediator
{
    public interface IComplaintMediator
    {
        List<DataModel.Models.Complaint> GetComplaints();
    }
}
