using ABCompany.Complaint.Repository;
using System.Collections.Generic;

namespace ABCompany.Complaint.Mediator
{
    public class ComplaintMediator : IComplaintMediator
    {
        private readonly IDataModelService _dataModelServiceInterface;

        public ComplaintMediator(IDataModelService dataModelServiceInterface)
        {
            _dataModelServiceInterface = dataModelServiceInterface;
        }

        public List<DataModel.Models.Complaint> GetComplaints()
        {
            return _dataModelServiceInterface.GetComplaints();
        }
    }
}